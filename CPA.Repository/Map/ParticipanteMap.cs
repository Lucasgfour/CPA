using CPA.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Repository.Map {
    public class ParticipanteMap : IEntityTypeConfiguration<Participante> {

        public void Configure(EntityTypeBuilder<Participante> builder) {

            builder.ToTable("questionario_participante");

            builder.HasKey(x => x.id);

            builder.Property(x => x.chave).HasMaxLength(32).IsRequired();

            builder.HasOne(x => x.questionario);

            builder.Property(x => x.data_resposta).IsRequired();

            

        }

    }
}
