using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPA.ApplicationWeb.Migrations
{
    public partial class FirstVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cad_instituicao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    documento = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false, defaultValue: "")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidade = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    presidenteCpa = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValue: "")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cad_instituicao", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ger_questionario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    instituicaoid = table.Column<int>(type: "int", nullable: true),
                    data_inicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_fim = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    titulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    chave = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "varchar(750)", maxLength: 750, nullable: true, defaultValue: "")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ger_questionario", x => x.id);
                    table.ForeignKey(
                        name: "FK_ger_questionario_cad_instituicao_instituicaoid",
                        column: x => x.instituicaoid,
                        principalTable: "cad_instituicao",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "questionario_participante",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    chave = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    questionarioid = table.Column<int>(type: "int", nullable: true),
                    data_resposta = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionario_participante", x => x.id);
                    table.ForeignKey(
                        name: "FK_questionario_participante_ger_questionario_questionarioid",
                        column: x => x.questionarioid,
                        principalTable: "ger_questionario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "questionario_pergunta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    questionarioid = table.Column<int>(type: "int", nullable: true),
                    aluno = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    professor = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    administrativo = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    descricao = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<int>(type: "int", nullable: false),
                    posicao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionario_pergunta", x => x.id);
                    table.ForeignKey(
                        name: "FK_questionario_pergunta_ger_questionario_questionarioid",
                        column: x => x.questionarioid,
                        principalTable: "ger_questionario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "questionario_opcao_resposta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    perguntaid = table.Column<int>(type: "int", nullable: true),
                    valor = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionario_opcao_resposta", x => x.id);
                    table.ForeignKey(
                        name: "FK_questionario_opcao_resposta_questionario_pergunta_perguntaid",
                        column: x => x.perguntaid,
                        principalTable: "questionario_pergunta",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "questionario_resposta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    participanteid = table.Column<int>(type: "int", nullable: true),
                    perguntaid = table.Column<int>(type: "int", nullable: true),
                    valor = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true, defaultValue: "")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionario_resposta", x => x.id);
                    table.ForeignKey(
                        name: "FK_questionario_resposta_questionario_participante_participante~",
                        column: x => x.participanteid,
                        principalTable: "questionario_participante",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_questionario_resposta_questionario_pergunta_perguntaid",
                        column: x => x.perguntaid,
                        principalTable: "questionario_pergunta",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_cad_instituicao_documento",
                table: "cad_instituicao",
                column: "documento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cad_instituicao_email",
                table: "cad_instituicao",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ger_questionario_instituicaoid",
                table: "ger_questionario",
                column: "instituicaoid");

            migrationBuilder.CreateIndex(
                name: "IX_questionario_opcao_resposta_perguntaid",
                table: "questionario_opcao_resposta",
                column: "perguntaid");

            migrationBuilder.CreateIndex(
                name: "IX_questionario_participante_questionarioid",
                table: "questionario_participante",
                column: "questionarioid");

            migrationBuilder.CreateIndex(
                name: "IX_questionario_pergunta_questionarioid",
                table: "questionario_pergunta",
                column: "questionarioid");

            migrationBuilder.CreateIndex(
                name: "IX_questionario_resposta_participanteid",
                table: "questionario_resposta",
                column: "participanteid");

            migrationBuilder.CreateIndex(
                name: "IX_questionario_resposta_perguntaid",
                table: "questionario_resposta",
                column: "perguntaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "questionario_opcao_resposta");

            migrationBuilder.DropTable(
                name: "questionario_resposta");

            migrationBuilder.DropTable(
                name: "questionario_participante");

            migrationBuilder.DropTable(
                name: "questionario_pergunta");

            migrationBuilder.DropTable(
                name: "ger_questionario");

            migrationBuilder.DropTable(
                name: "cad_instituicao");
        }
    }
}
