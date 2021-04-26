using Microsoft.EntityFrameworkCore.Migrations;

namespace GamePlace.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    IdJogo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    AnoLancamento = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    Preco = table.Column<string>(nullable: true),
                    Classificacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.IdJogo);
                });

            migrationBuilder.CreateTable(
                name: "UtilizadorRegistado",
                columns: table => new
                {
                    IdUtilizador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    Morada = table.Column<string>(maxLength: 60, nullable: false),
                    CodPostal = table.Column<string>(maxLength: 30, nullable: false),
                    Telemovel = table.Column<string>(maxLength: 14, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilizadorRegistado", x => x.IdUtilizador);
                });

            migrationBuilder.CreateTable(
                name: "Recibo",
                columns: table => new
                {
                    IdRecibo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JogoFK = table.Column<int>(nullable: false),
                    UtilizadorFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibo", x => x.IdRecibo);
                    table.ForeignKey(
                        name: "FK_Recibo_Jogos_JogoFK",
                        column: x => x.JogoFK,
                        principalTable: "Jogos",
                        principalColumn: "IdJogo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recibo_UtilizadorRegistado_UtilizadorFK",
                        column: x => x.UtilizadorFK,
                        principalTable: "UtilizadorRegistado",
                        principalColumn: "IdUtilizador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recibo_JogoFK",
                table: "Recibo",
                column: "JogoFK");

            migrationBuilder.CreateIndex(
                name: "IX_Recibo_UtilizadorFK",
                table: "Recibo",
                column: "UtilizadorFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recibo");

            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "UtilizadorRegistado");
        }
    }
}
