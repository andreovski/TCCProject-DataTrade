using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carteiras_Usuario_UsuarioID",
                table: "Carteiras");

            migrationBuilder.DropForeignKey(
                name: "FK_Estrategias_Usuario_UsuarioID",
                table: "Estrategias");

            migrationBuilder.DropForeignKey(
                name: "FK_Login_Usuario_UsuarioID",
                table: "Login");

            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Usuario_UsuarioID",
                table: "Operacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Traders_Usuario_UsuarioID",
                table: "Traders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

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

            migrationBuilder.RenameIndex(
                name: "IX_Login_UsuarioID",
                table: "Logins",
                newName: "IX_Logins_UsuarioID");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Logins",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Logins",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logins",
                table: "Logins",
                column: "LoginID");

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
                name: "FK_Logins_Usuarios_UsuarioID",
                table: "Logins",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operacoes_Usuarios_UsuarioID",
                table: "Operacoes",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traders_Usuarios_UsuarioID",
                table: "Traders",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carteiras_Usuarios_UsuarioID",
                table: "Carteiras");

            migrationBuilder.DropForeignKey(
                name: "FK_Estrategias_Usuarios_UsuarioID",
                table: "Estrategias");

            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Usuarios_UsuarioID",
                table: "Logins");

            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Usuarios_UsuarioID",
                table: "Operacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Traders_Usuarios_UsuarioID",
                table: "Traders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Logins",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "Email",
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

            migrationBuilder.RenameIndex(
                name: "IX_Logins_UsuarioID",
                table: "Login",
                newName: "IX_Login_UsuarioID");

            migrationBuilder.AddColumn<string>(
                name: "EmailUsuario",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Login",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailLogin",
                table: "Login",
                type: "nvarchar(max)",
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
                name: "FK_Login_Usuario_UsuarioID",
                table: "Login",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operacoes_Usuario_UsuarioID",
                table: "Operacoes",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traders_Usuario_UsuarioID",
                table: "Traders",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
