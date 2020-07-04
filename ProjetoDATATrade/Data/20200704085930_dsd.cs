using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class dsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes");

            migrationBuilder.DropColumn(
                name: "OperacaoID",
                table: "Estrategias");

            migrationBuilder.AlterColumn<int>(
                name: "EstrategiaID",
                table: "Operacoes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes",
                column: "EstrategiaID",
                principalTable: "Estrategias",
                principalColumn: "EstrategiaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes");

            migrationBuilder.AlterColumn<int>(
                name: "EstrategiaID",
                table: "Operacoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "OperacaoID",
                table: "Estrategias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes",
                column: "EstrategiaID",
                principalTable: "Estrategias",
                principalColumn: "EstrategiaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
