using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class nullsValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Usuarios_UsuarioID",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes");

            migrationBuilder.DropIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "IndicadorID",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "IndicadorTrader",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Traders");

            migrationBuilder.AlterColumn<int>(
                name: "EstrategiaID",
                table: "Operacoes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioID",
                table: "Logins",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TradeID",
                table: "Indicadores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins",
                column: "UsuarioID",
                unique: true,
                filter: "[UsuarioID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Usuarios_UsuarioID",
                table: "Logins",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Logins_Usuarios_UsuarioID",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes");

            migrationBuilder.DropIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "TradeID",
                table: "Indicadores");

            migrationBuilder.AddColumn<int>(
                name: "IndicadorID",
                table: "Traders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IndicadorTrader",
                table: "Traders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Perfil",
                table: "Traders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "EstrategiaID",
                table: "Operacoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioID",
                table: "Logins",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins",
                column: "UsuarioID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Usuarios_UsuarioID",
                table: "Logins",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

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
