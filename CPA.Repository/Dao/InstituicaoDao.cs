using CPA.Data.Model;
using CPA.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Repository.Dao {
    public class InstituicaoDao : IInstituicaoDao {

        private readonly Context _context;

        public InstituicaoDao(Context context) {
            _context = context;
        }
        

        public Instituicao? GetById(int id) {

            var instituicao = _context
                .instituicaos
                .AsTracking()
                .Where(x => x.id == id)
                .FirstOrDefault();

            return instituicao;

        }

        public Instituicao? GetByLogin(string email, string password) {

            var instituicao = _context
                .instituicaos
                .AsNoTracking()
                .Where(x => x.email.Equals(email) && x.senha.Equals(password))
                .FirstOrDefault();

            return instituicao;

        }

        public void Add(Instituicao instituicao) {
            
            _context.Add(instituicao);

            _context.SaveChanges();

        }

        public void Update(Instituicao instituicao) {

            var oldInstituicao = GetById(instituicao.id);

            if (oldInstituicao == null)
                throw new Exception($"Instituição de id '{instituicao.id}' não encontrada.");

            oldInstituicao.presidenteCpa = instituicao.presidenteCpa;
            oldInstituicao.cidade = instituicao.cidade;
            oldInstituicao.nome = instituicao.nome;
            oldInstituicao.telefone = instituicao.telefone;

            _context.SaveChanges();

        }

        public void ChangePassword(string password, string newPassword, Instituicao instituicao) {

            var oldInstituicao = GetById(instituicao.id);

            if (oldInstituicao == null)
                throw new Exception($"Instituição de id '{instituicao.id}' não encontrada.");



        }
    }
}
