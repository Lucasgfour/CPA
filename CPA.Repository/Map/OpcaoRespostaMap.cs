using CPA.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Repository.Map {
    internal class OpcaoRespostaMap : IEntityTypeConfiguration<OpcaoResposta> {

        public void Configure(EntityTypeBuilder<OpcaoResposta> builder) {

            builder.ToTable("questionario_opcao_resposta");

            builder.HasKey(x => x.id);

            builder.HasOne(x => x.pergunta).WithMany(x => x.opcaoRespostas);

            builder.Property(x => x.valor).HasMaxLength(250).IsRequired();



        }
    }
}
