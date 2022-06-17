using CPA.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Repository.Map {
    internal class RespostaMap : IEntityTypeConfiguration<Resposta> {

        public void Configure(EntityTypeBuilder<Resposta> builder) {

            builder.ToTable("questionario_resposta");

            builder.HasKey(x => x.id);

            builder.HasOne(x => x.participante);

            builder.HasOne(x => x.pergunta);

            builder.Property(x => x.valor).HasMaxLength(250).HasDefaultValue("");

        }

    }
}
