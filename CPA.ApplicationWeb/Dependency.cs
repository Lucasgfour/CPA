using CPA.Data.Interface;
using CPA.Data.Model;
using CPA.Data.Rules;
using CPA.Repository;
using CPA.Repository.Dao;
using CPA.Repository.Interface;
using CPA.Service.Interface;
using CPA.Service.Services;
using Microsoft.EntityFrameworkCore;

namespace CPA.ApplicationWeb {
    public static class Dependency {

        public static void Configure(IServiceCollection services, string cnnString) {

            // --- DbContext -----------------------------------------------------------

            services.AddDbContext<Context>(options => options.UseMySql(cnnString, ServerVersion.AutoDetect(cnnString), x => x.MigrationsAssembly("CPA.ApplicationWeb")));

            // --- Repository-----------------------------------------------------------

            services.AddScoped<IInstituicaoDao, InstituicaoDao>();
            services.AddScoped<IQuestionarioDao, QuestionarioDao>();

            // --- Services ------------------------------------------------------------

            services.AddScoped<IInstituicaoService, InstituicaoService>();
            services.AddScoped<IQuestionarioService, QuestionarioService>();

            // --- Rules ---------------------------------------------------------------

            services.AddScoped<IRules<Instituicao>, InstituicaoRules>();
            services.AddScoped<IRules<Questionario>, QuestionarioRules>();

        }

    }
}
