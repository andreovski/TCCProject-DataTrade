using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class initial_semPropTrade_Carteira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders");

            migrationBuilder.DropIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras",
                column: "UsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders");

            migrationBuilder.DropIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders",
                column: "UsuarioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras",
                column: "UsuarioID",
                unique: true);
        }
    }
}
