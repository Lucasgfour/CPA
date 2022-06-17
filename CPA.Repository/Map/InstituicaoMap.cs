using CPA.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPA.Repository.Map {
    public class InstituicaoMap : IEntityTypeConfiguration<Instituicao> {

        public void Configure(EntityTypeBuilder<Instituicao> builder) {

            builder.ToTable("cad_instituicao");

            builder.HasKey(x => x.id);

            builder.Property(x => x.nome).HasMaxLength(70).IsRequired();

            builder.Property(x => x.documento).HasMaxLength(18).IsRequired();
            builder.HasIndex(x => x.documento).IsUnique();

            builder.Property(x => x.telefone).HasMaxLength(70).HasDefaultValue("");

            builder.Property(x => x.email).HasMaxLength(50).IsRequired();
            builder.HasIndex(x => x.email).IsUnique();

            builder.Property(x => x.cidade).HasMaxLength(70).IsRequired();

            builder.Property(x => x.senha).HasMaxLength(32).IsRequired();

            builder.Property(x => x.presidenteCpa).HasMaxLength(50).HasDefaultValue("");
            

        }

    }
}
