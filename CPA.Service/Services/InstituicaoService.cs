using CPA.Commom.Tools;
using CPA.Data.Interface;
using CPA.Data.Model;
using CPA.Repository.Interface;
using CPA.Service.Interface;

namespace CPA.Service.Services {
    public class InstituicaoService : IInstituicaoService {

        private readonly IInstituicaoDao _instituicaoDao;
        private readonly IRules<Instituicao> _rules;

        public InstituicaoService(IInstituicaoDao instituicaoDao, IRules<Instituicao> rules) {
            _instituicaoDao = instituicaoDao;
            _rules = rules;
        }

        public Instituicao GetByLogin(string email, string password) {

            var instituicao = _instituicaoDao.GetByLogin(email, Encrypt.GerarHashMd5(password));

            if (instituicao == null)
                throw new Exception("Login ou Senha inválidos.");

            return instituicao;

        }

        public Instituicao GetById(int id) {

            var instituicao = _instituicaoDao.GetById(id);

            if (instituicao == null)
                throw new Exception("ID informado é inválido.");

            return instituicao;

        }

        public void Add(Instituicao instituicao) {

            _rules.ValidationInsert(instituicao);

            instituicao.senha = Encrypt.GerarHashMd5(instituicao.senha);

            _instituicaoDao.Add(instituicao);

        }

        public void Update(Instituicao instituicao) {

            _rules.ValidationUpdate(instituicao);

            _instituicaoDao.Update(instituicao);

        }
    }
}
