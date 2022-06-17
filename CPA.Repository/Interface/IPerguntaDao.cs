using CPA.Data.Model;

namespace CPA.Repository.Interface {
    public interface IPerguntaDao {

        List<Pergunta> GetAllByQuestionario(int questionarioId);
        Pergunta GetById(int id);
        Pergunta Add(Pergunta pergunta);
        Pergunta Update(Pergunta pergunta);
        void Delete(int id);


    }
}
