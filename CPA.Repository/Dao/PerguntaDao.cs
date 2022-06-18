using CPA.Data.Model;
using CPA.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace CPA.Repository.Dao {
    internal class PerguntaDao {

        private readonly IQuestionarioDao _questionarioDao;
        private readonly Context _context;

        public PerguntaDao(IQuestionarioDao questionarioDao, Context context) {
            this._questionarioDao = questionarioDao;
            this._context = context;
        }

        public List<Pergunta> GetAllByQuestionario(int questionarioId) {

            var questionario = _questionarioDao.GetById(questionarioId);

            var perguntas = _context
                .perguntas
                .Include(x => x.questionario)
                .Where(x => x.questionario.id == questionarioId)
                .ToList();

            return perguntas;
        }

    }
}
