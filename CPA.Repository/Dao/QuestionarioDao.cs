using CPA.Data.Model;
using CPA.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace CPA.Repository.Dao {
    public class QuestionarioDao : IQuestionarioDao {

        private readonly Context _context;

        public QuestionarioDao(Context context) {
            this._context = context;
        }

        public Questionario? GetById(int id) {

            var questionario = _context
                .questionarios
                .AsTracking()
                .Include(x => x.instituicao)
                .Where(x => x.id == id)
                .FirstOrDefault();

            return questionario;

        }

        public Questionario? GetByChave(string chave) {

            var questionario = _context
                .questionarios
                .AsTracking()
                .Where(x => x.chave.Equals(chave))
                .FirstOrDefault();

            return questionario;

        }

        public void Add(Questionario questionario) {

            _context.questionarios.Add(questionario);

            _context.SaveChanges();

        }

        public void Update(Questionario questionario) {

            var oldQuestionario = GetById(questionario.id);

            if (oldQuestionario == null)
                throw new Exception("Questionário não localizado.");

            oldQuestionario.titulo = questionario.titulo;
            oldQuestionario.descricao = questionario.descricao;
            oldQuestionario.data_fim = questionario.data_fim;

            _context.SaveChanges();

        }

    }
}
