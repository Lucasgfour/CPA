// <auto-generated />
using System;
using CPA.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CPA.ApplicationWeb.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CPA.Data.Model.Instituicao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("varchar(18)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<string>("presidenteCpa")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasDefaultValue("");

                    b.HasKey("id");

                    b.HasIndex("documento")
                        .IsUnique();

                    b.HasIndex("email")
                        .IsUnique();

                    b.ToTable("cad_instituicao", (string)null);
                });

            modelBuilder.Entity("CPA.Data.Model.OpcaoResposta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("perguntaid")
                        .HasColumnType("int");

                    b.Property<string>("valor")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("id");

                    b.HasIndex("perguntaid");

                    b.ToTable("questionario_opcao_resposta", (string)null);
                });

            modelBuilder.Entity("CPA.Data.Model.Participante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("chave")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("data_resposta")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("questionarioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("questionarioid");

                    b.ToTable("questionario_participante", (string)null);
                });

            modelBuilder.Entity("CPA.Data.Model.Pergunta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("administrativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("aluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("posicao")
                        .HasColumnType("int");

                    b.Property<int>("professor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("questionarioid")
                        .HasColumnType("int");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("questionarioid");

                    b.ToTable("questionario_pergunta", (string)null);
                });

            modelBuilder.Entity("CPA.Data.Model.Questionario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("chave")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime?>("data_fim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("data_inicio")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("descricao")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(750)
                        .HasColumnType("varchar(750)")
                        .HasDefaultValue("");

                    b.Property<int?>("instituicaoid")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("id");

                    b.HasIndex("instituicaoid");

                    b.ToTable("ger_questionario", (string)null);
                });

            modelBuilder.Entity("CPA.Data.Model.Resposta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("participanteid")
                        .HasColumnType("int");

                    b.Property<int?>("perguntaid")
                        .HasColumnType("int");

                    b.Property<string>("valor")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasDefaultValue("");

                    b.HasKey("id");

                    b.HasIndex("participanteid");

                    b.HasIndex("perguntaid");

                    b.ToTable("questionario_resposta", (string)null);
                });

            modelBuilder.Entity("CPA.Data.Model.OpcaoResposta", b =>
                {
                    b.HasOne("CPA.Data.Model.Pergunta", "pergunta")
                        .WithMany("opcaoRespostas")
                        .HasForeignKey("perguntaid");

                    b.Navigation("pergunta");
                });

            modelBuilder.Entity("CPA.Data.Model.Participante", b =>
                {
                    b.HasOne("CPA.Data.Model.Questionario", "questionario")
                        .WithMany()
                        .HasForeignKey("questionarioid");

                    b.Navigation("questionario");
                });

            modelBuilder.Entity("CPA.Data.Model.Pergunta", b =>
                {
                    b.HasOne("CPA.Data.Model.Questionario", "questionario")
                        .WithMany("perguntas")
                        .HasForeignKey("questionarioid");

                    b.Navigation("questionario");
                });

            modelBuilder.Entity("CPA.Data.Model.Questionario", b =>
                {
                    b.HasOne("CPA.Data.Model.Instituicao", "instituicao")
                        .WithMany("questionarios")
                        .HasForeignKey("instituicaoid");

                    b.Navigation("instituicao");
                });

            modelBuilder.Entity("CPA.Data.Model.Resposta", b =>
                {
                    b.HasOne("CPA.Data.Model.Participante", "participante")
                        .WithMany()
                        .HasForeignKey("participanteid");

                    b.HasOne("CPA.Data.Model.Pergunta", "pergunta")
                        .WithMany()
                        .HasForeignKey("perguntaid");

                    b.Navigation("participante");

                    b.Navigation("pergunta");
                });

            modelBuilder.Entity("CPA.Data.Model.Instituicao", b =>
                {
                    b.Navigation("questionarios");
                });

            modelBuilder.Entity("CPA.Data.Model.Pergunta", b =>
                {
                    b.Navigation("opcaoRespostas");
                });

            modelBuilder.Entity("CPA.Data.Model.Questionario", b =>
                {
                    b.Navigation("perguntas");
                });
#pragma warning restore 612, 618
        }
    }
}
