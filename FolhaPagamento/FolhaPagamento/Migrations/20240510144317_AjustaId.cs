using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolhaPagamento.Migrations
{
    /// <inheritdoc />
    public partial class AjustaId : Migration
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

            migrationBuilder.RenameColumn(
                name: "funcionarioId",
                table: "TabelaFolha",
                newName: "funcionarioid");

            migrationBuilder.AddColumn<string>(
                name: "funcionarioId1",
                table: "TabelaFuncionario",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "funcionarioid",
                table: "TabelaFolha",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "funcionarioId",
                table: "TabelaFolha",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabelaFolha_funcionarioId",
                table: "TabelaFolha",
                column: "funcionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TabelaFolha_TabelaFuncionario_funcionarioId",
                table: "TabelaFolha",
                column: "funcionarioId",
                principalTable: "TabelaFuncionario",
                principalColumn: "funcionarioId");
        }
    }
}
