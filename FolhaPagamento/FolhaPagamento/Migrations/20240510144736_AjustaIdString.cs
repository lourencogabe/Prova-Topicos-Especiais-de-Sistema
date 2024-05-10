using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolhaPagamento.Migrations
{
    /// <inheritdoc />
    public partial class AjustaIdString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabelaFuncionario_TabelaFolha_funcionarioId1",
                table: "TabelaFuncionario");

            migrationBuilder.DropIndex(
                name: "IX_TabelaFuncionario_funcionarioId1",
                table: "TabelaFuncionario");

            migrationBuilder.DropColumn(
                name: "funcionarioId1",
                table: "TabelaFuncionario");

            migrationBuilder.RenameColumn(
                name: "funcionarioid",
                table: "TabelaFolha",
                newName: "funcionarioId");

            migrationBuilder.AlterColumn<string>(
                name: "funcionarioId",
                table: "TabelaFuncionario",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabelaFolha_TabelaFuncionario_funcionarioId",
                table: "TabelaFolha");

            migrationBuilder.DropIndex(
                name: "IX_TabelaFolha_funcionarioId",
                table: "TabelaFolha");

            migrationBuilder.RenameColumn(
                name: "funcionarioId",
                table: "TabelaFolha",
                newName: "funcionarioid");

            migrationBuilder.AlterColumn<int>(
                name: "funcionarioId",
                table: "TabelaFuncionario",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "funcionarioId1",
                table: "TabelaFuncionario",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabelaFuncionario_funcionarioId1",
                table: "TabelaFuncionario",
                column: "funcionarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TabelaFuncionario_TabelaFolha_funcionarioId1",
                table: "TabelaFuncionario",
                column: "funcionarioId1",
                principalTable: "TabelaFolha",
                principalColumn: "Id");
        }
    }
}
