using CPA.Data.Enum;
using CPA.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Repository.Map {
    public class PerguntaMap : IEntityTypeConfiguration<Pergunta> {

        public void Configure(EntityTypeBuilder<Pergunta> builder) {

            builder.ToTable("questionario_pergunta");

            builder.HasKey(x => x.id);

            builder.HasOne(x => x.questionario).WithMany();

            builder.Property(x => x.aluno).HasDefaultValue(Permissao.Nao);

            builder.Property(x => x.professor).HasDefaultValue(Permissao.Nao);

            builder.Property(x => x.administrativo).HasDefaultValue(Permissao.Nao);

            builder.Property(x => x.descricao).HasMaxLength(500).IsRequired();

            builder.Property(x => x.tipo).IsRequired();

            builder.Property(x => x.posicao).IsRequired();

        }

    }
}
