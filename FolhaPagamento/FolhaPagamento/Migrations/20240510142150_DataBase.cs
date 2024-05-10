using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolhaPagamento.Migrations
{
    /// <inheritdoc />
    public partial class DataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaFuncionario",
                columns: table => new
                {
                    funcionarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    cpf = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaFuncionario", x => x.funcionarioId);
                });

            migrationBuilder.CreateTable(
                name: "TabelaFolha",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    valor = table.Column<float>(type: "REAL", nullable: true),
                    quantidade = table.Column<int>(type: "INTEGER", nullable: true),
                    mes = table.Column<int>(type: "INTEGER", nullable: true),
                    ano = table.Column<int>(type: "INTEGER", nullable: true),
                    salarioBruto = table.Column<float>(type: "REAL", nullable: true),
                    impostoIrrf = table.Column<float>(type: "REAL", nullable: true),
                    impostoInss = table.Column<float>(type: "REAL", nullable: true),
                    impostoFgts = table.Column<float>(type: "REAL", nullable: true),
                    salarioLiquido = table.Column<float>(type: "REAL", nullable: true),
                    funcionarioId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaFolha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabelaFolha_TabelaFuncionario_funcionarioId",
                        column: x => x.funcionarioId,
                        principalTable: "TabelaFuncionario",
                        principalColumn: "funcionarioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabelaFolha_funcionarioId",
                table: "TabelaFolha",
                column: "funcionarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaFolha");

            migrationBuilder.DropTable(
                name: "TabelaFuncionario");
        }
    }
}
