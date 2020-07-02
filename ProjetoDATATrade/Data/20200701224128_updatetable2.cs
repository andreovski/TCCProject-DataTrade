using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class updatetable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carteiras_Usuarios_UsuarioID",
                table: "Carteiras");

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
                name: "FK_Operacoes_Usuarios_UsuarioID",
                table: "Operacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_perfilTraders_Usuarios_UsuarioID",
                table: "perfilTraders");

            migrationBuilder.DropForeignKey(
                name: "FK_Traders_Usuarios_UsuarioID",
                table: "Traders");

            migrationBuilder.DropIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders");

            migrationBuilder.DropIndex(
                name: "IX_perfilTraders_UsuarioID",
                table: "perfilTraders");

            migrationBuilder.DropIndex(
                name: "IX_Indicadores_UsuarioID",
                table: "Indicadores");

            migrationBuilder.DropIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Logins",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "Indicadores",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "PerfilTrader",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "perfilTraders");

            migrationBuilder.DropColumn(
                name: "Estrategia",
                table: "Operacoes");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Logins");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Logins",
                newName: "Login");

            migrationBuilder.AddColumn<int>(
                name: "IndicadorID",
                table: "Traders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IndicadorTrader",
                table: "Traders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Perfil",
                table: "Traders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PerfilTraderID",
                table: "Traders",
                nullable: false,
                defaultValue: 0);

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
                name: "TraderID",
                table: "Indicadores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailUsuario",
                table: "Usuario",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioID",
                table: "Login",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailLogin",
                table: "Login",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "UsuarioID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "LoginID");

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
                name: "IX_Indicadores_TraderID",
                table: "Indicadores",
                column: "TraderID");

            migrationBuilder.CreateIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras",
                column: "UsuarioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Login_UsuarioID",
                table: "Login",
                column: "UsuarioID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carteiras_Usuario_UsuarioID",
                table: "Carteiras",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estrategias_Usuario_UsuarioID",
                table: "Estrategias",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Indicadores_Traders_TraderID",
                table: "Indicadores",
                column: "TraderID",
                principalTable: "Traders",
                principalColumn: "TraderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Login_Usuario_UsuarioID",
                table: "Login",
                column: "UsuarioID",
                principalTable: "Usuario",
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
                name: "FK_Operacoes_Usuario_UsuarioID",
                table: "Operacoes",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traders_perfilTraders_PerfilTraderID",
                table: "Traders",
                column: "PerfilTraderID",
                principalTable: "perfilTraders",
                principalColumn: "PerfilTraderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traders_Usuario_UsuarioID",
                table: "Traders",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carteiras_Usuario_UsuarioID",
                table: "Carteiras");

            migrationBuilder.DropForeignKey(
                name: "FK_Estrategias_Usuario_UsuarioID",
                table: "Estrategias");

            migrationBuilder.DropForeignKey(
                name: "FK_Indicadores_Traders_TraderID",
                table: "Indicadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Login_Usuario_UsuarioID",
                table: "Login");

            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Usuario_UsuarioID",
                table: "Operacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Traders_perfilTraders_PerfilTraderID",
                table: "Traders");

            migrationBuilder.DropForeignKey(
                name: "FK_Traders_Usuario_UsuarioID",
                table: "Traders");

            migrationBuilder.DropIndex(
                name: "IX_Traders_PerfilTraderID",
                table: "Traders");

            migrationBuilder.DropIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders");

            migrationBuilder.DropIndex(
                name: "IX_Operacoes_EstrategiaID",
                table: "Operacoes");

            migrationBuilder.DropIndex(
                name: "IX_Indicadores_TraderID",
                table: "Indicadores");

            migrationBuilder.DropIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.DropIndex(
                name: "IX_Login_UsuarioID",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "IndicadorID",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "IndicadorTrader",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "PerfilTraderID",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "EstrategiaID",
                table: "Operacoes");

            migrationBuilder.DropColumn(
                name: "EstrategiaOperacao",
                table: "Operacoes");

            migrationBuilder.DropColumn(
                name: "TraderID",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "EmailUsuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "EmailLogin",
                table: "Login");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Login",
                newName: "Logins");

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
                name: "UsuarioID",
                table: "Indicadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Nascimento",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioID",
                table: "Logins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logins",
                table: "Logins",
                column: "LoginID");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_perfilTraders_UsuarioID",
                table: "perfilTraders",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Indicadores_UsuarioID",
                table: "Indicadores",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UsuarioID",
                table: "Logins",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Carteiras_Usuarios_UsuarioID",
                table: "Carteiras",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Operacoes_Usuarios_UsuarioID",
                table: "Operacoes",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_perfilTraders_Usuarios_UsuarioID",
                table: "perfilTraders",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Traders_Usuarios_UsuarioID",
                table: "Traders",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
