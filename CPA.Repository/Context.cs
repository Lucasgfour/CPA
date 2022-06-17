using CPA.Data.Model;
using CPA.Repository.Map;
using Microsoft.EntityFrameworkCore;

namespace CPA.Repository {
    public class Context : DbContext {

        public Context(DbContextOptions<Context> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration<Instituicao>(new InstituicaoMap());
            modelBuilder.ApplyConfiguration<OpcaoResposta>(new OpcaoRespostaMap());
            modelBuilder.ApplyConfiguration<Participante>(new ParticipanteMap());
            modelBuilder.ApplyConfiguration<Pergunta>(new PerguntaMap());
            modelBuilder.ApplyConfiguration<Questionario>(new QuestionarioMap());
            modelBuilder.ApplyConfiguration<Resposta>(new RespostaMap());

        }

        public DbSet<Instituicao> instituicaos { get; set; }
        public DbSet<OpcaoResposta> opcaos { get; set; }
        public DbSet<Participante> participantes { get; set; }
        public DbSet<Pergunta> perguntas { get; set; }
        public DbSet<Questionario> questionarios { get; set; }
        public DbSet<Resposta> respostas { get; set; }


    }
}
