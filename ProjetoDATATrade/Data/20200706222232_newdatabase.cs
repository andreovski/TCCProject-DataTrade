using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class newdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estrategias_Usuarios_UsuarioID",
                table: "Estrategias");

            migrationBuilder.DropForeignKey(
                name: "FK_Indicadores_Usuarios_UsuarioID",
                table: "Indicadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Usuarios_UsuarioID",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_perfilTraders_Usuarios_UsuarioID",
                table: "perfilTraders");

            migrationBuilder.DropIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_perfilTraders",
                table: "perfilTraders");

            migrationBuilder.DropIndex(
                name: "IX_perfilTraders_UsuarioID",
                table: "perfilTraders");

            migrationBuilder.DropIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Indicadores_UsuarioID",
                table: "Indicadores");

            migrationBuilder.DropIndex(
                name: "IX_Estrategias_UsuarioID",
                table: "Estrategias");

            migrationBuilder.DropIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras");

            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DiasOperacao",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "HorarioOperacao",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "Indicadores",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "PerfilTrader",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "perfilTraders");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "perfilTraders");

            migrationBuilder.DropColumn(
                name: "Estrategia",
                table: "Operacoes");

            migrationBuilder.DropColumn(
                name: "NumeroOperacao",
                table: "Operacoes");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "NomeEstrategia",
                table: "Estrategias");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Estrategias");

            migrationBuilder.RenameTable(
                name: "perfilTraders",
                newName: "PerfilTraders");

            migrationBuilder.AddColumn<string>(
                name: "DiasTrader",
                table: "Traders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HorarioTrader",
                table: "Traders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IndicadorTrader",
                table: "Traders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PerfilTraderID",
                table: "Traders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "PerfilTraders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EstrategiaID",
                table: "Operacoes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EstrategiaOperacao",
                table: "Operacoes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroOp",
                table: "Operacoes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioID",
                table: "Logins",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Logins",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Logins",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Indicadores",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TradeID",
                table: "Indicadores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TraderID",
                table: "Indicadores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Estrategias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerfilTraders",
                table: "PerfilTraders",
                column: "PerfilTraderID");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_PerfilTraderID",
                table: "Traders",
                column: "PerfilTraderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders",
                column: "UsuarioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Operacoes_EstrategiaID",
                table: "Operacoes",
                column: "EstrategiaID");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins",
                column: "UsuarioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Indicadores_TraderID",
                table: "Indicadores",
                column: "TraderID");

            migrationBuilder.CreateIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras",
                column: "UsuarioID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Indicadores_Traders_TraderID",
                table: "Indicadores",
                column: "TraderID",
                principalTable: "Traders",
                principalColumn: "TraderID",
                onDelete: ReferentialAction.Restrict);

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traders_PerfilTraders_PerfilTraderID",
                table: "Traders",
                column: "PerfilTraderID",
                principalTable: "PerfilTraders",
                principalColumn: "PerfilTraderID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Indicadores_Traders_TraderID",
                table: "Indicadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Usuarios_UsuarioID",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Traders_PerfilTraders_PerfilTraderID",
                table: "Traders");

            migrationBuilder.DropIndex(
                name: "IX_Traders_PerfilTraderID",
                table: "Traders");

            migrationBuilder.DropIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerfilTraders",
                table: "PerfilTraders");

            migrationBuilder.DropIndex(
                name: "IX_Operacoes_EstrategiaID",
                table: "Operacoes");

            migrationBuilder.DropIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Indicadores_TraderID",
                table: "Indicadores");

            migrationBuilder.DropIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras");

            migrationBuilder.DropColumn(
                name: "DiasTrader",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "HorarioTrader",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "IndicadorTrader",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "PerfilTraderID",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "PerfilTraders");

            migrationBuilder.DropColumn(
                name: "EstrategiaID",
                table: "Operacoes");

            migrationBuilder.DropColumn(
                name: "EstrategiaOperacao",
                table: "Operacoes");

            migrationBuilder.DropColumn(
                name: "NumeroOp",
                table: "Operacoes");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "TradeID",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "TraderID",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Estrategias");

            migrationBuilder.RenameTable(
                name: "PerfilTraders",
                newName: "perfilTraders");

            migrationBuilder.AddColumn<DateTime>(
                name: "Nascimento",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DiasOperacao",
                table: "Traders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HorarioOperacao",
                table: "Traders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Indicadores",
                table: "Traders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PerfilTrader",
                table: "Traders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "perfilTraders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "perfilTraders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estrategia",
                table: "Operacoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroOperacao",
                table: "Operacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioID",
                table: "Logins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Indicadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Indicadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeEstrategia",
                table: "Estrategias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Estrategias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_perfilTraders",
                table: "perfilTraders",
                column: "PerfilTraderID");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_perfilTraders_UsuarioID",
                table: "perfilTraders",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Indicadores_UsuarioID",
                table: "Indicadores",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Estrategias_UsuarioID",
                table: "Estrategias",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Estrategias_Usuarios_UsuarioID",
                table: "Estrategias",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Indicadores_Usuarios_UsuarioID",
                table: "Indicadores",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Usuarios_UsuarioID",
                table: "Logins",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_perfilTraders_Usuarios_UsuarioID",
                table: "perfilTraders",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
