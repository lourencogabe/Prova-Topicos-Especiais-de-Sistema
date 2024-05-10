using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolhaPagamento.Migrations
{
    /// <inheritdoc />
    public partial class RemoveReferencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabelaFolha_TabelaFuncionario_funcionarioId",
                table: "TabelaFolha");

            migrationBuilder.DropIndex(
                name: "IX_TabelaFolha_funcionarioId",
                table: "TabelaFolha");

            migrationBuilder.DropColumn(
                name: "funcionarioId",
                table: "TabelaFolha");

            migrationBuilder.AlterColumn<int>(
                name: "funcionarioId",
                table: "TabelaFuncionario",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "funcionarioId",
                table: "TabelaFuncionario",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "funcionarioId",
                table: "TabelaFolha",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabelaFolha_funcionarioId",
                table: "TabelaFolha",
                column: "funcionarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TabelaFolha_TabelaFuncionario_funcionarioId",
                table: "TabelaFolha",
                column: "funcionarioId",
                principalTable: "TabelaFuncionario",
                principalColumn: "funcionarioId");
        }
    }
}
