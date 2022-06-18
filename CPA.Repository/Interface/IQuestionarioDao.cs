using CPA.Data.Model;

namespace CPA.Repository.Interface {
    public interface IQuestionarioDao {
            
        Questionario? GetById(int id);

        Questionario? GetByChave(string chave);

        ICollection<Questionario> GetAll(int instituicao);

        void Add(Questionario questionario);

        void Update(Questionario questionario);


    }
}
