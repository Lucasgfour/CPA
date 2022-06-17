using CPA.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPA.Repository.Map {
    public class QuestionarioMap : IEntityTypeConfiguration<Questionario> {

        public void Configure(EntityTypeBuilder<Questionario> builder) {

            builder.ToTable("ger_questionario");

            builder.HasKey(x => x.id);

            builder.HasOne(x => x.instituicao).WithMany();

            builder.Property(x => x.data_inicio).IsRequired();

            builder.Property(x => x.data_fim);

            builder.Property(x => x.titulo).HasMaxLength(100).IsRequired();

            builder.Property(x => x.chave).HasMaxLength(32).IsRequired();

            builder.Property(x => x.descricao).HasMaxLength(750).HasDefaultValue("");

        }

    }
}
