using CPA.Commom.Tools;
using CPA.Data.Interface;
using CPA.Data.Model;
using CPA.Repository.Interface;
using CPA.Service.Interface;

namespace CPA.Service.Services {
    public class QuestionarioService : IQuestionarioService {

        private readonly IQuestionarioDao _questionarioDao;
        private readonly IRules<Questionario> _rules;
        private readonly IInstituicaoDao _instituicaoDao;

        public QuestionarioService(IQuestionarioDao questionarioDao, IRules<Questionario> rules, IInstituicaoDao instituicaoDao) {
            this._questionarioDao = questionarioDao;
            this._rules = rules;
            this._instituicaoDao = instituicaoDao;
        }

        public Questionario GetById(int id) {

            var questionario = _questionarioDao.GetById(id);

            if (questionario == null)
                throw new Exception("ID questionário informado não localizado.");

            return questionario;

        }

        public Questionario GetByChave(string chave) {

            var questionario = _questionarioDao.GetByChave(chave);

            if (questionario == null)
                throw new Exception("Chave informada não localizada.");

            return questionario;

        }

        public ICollection<Questionario> GetAll(int instituicao) {

            var questionarios = _questionarioDao.GetAll(instituicao);

            return questionarios;

        }

        public void Add(Questionario questionario, int instituicaoId) {

            questionario.instituicao = _instituicaoDao.GetById(instituicaoId);

            _rules.ValidationInsert(questionario);

            var strChave = $"KEY{questionario.instituicao.email}/{DateTime.Now.ToString("ddd MMMM yyyy HH mm ss fff")}";

            questionario.chave = Encrypt.GerarHashMd5(strChave);

            _questionarioDao.Add(questionario);

        }

        public void Update(Questionario questionario) {

            _rules.ValidationUpdate(questionario);

            _questionarioDao.Update(questionario);

        }



    }
}
