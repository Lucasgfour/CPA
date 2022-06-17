using CPA.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Service.Interface {
    public interface IInstituicaoService {

        Instituicao GetById(int id);

        Instituicao GetByLogin(string email, string password);

        void Add(Instituicao instituicao);
        void Update(Instituicao instituicao);

    }
}
