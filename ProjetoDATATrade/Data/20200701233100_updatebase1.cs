using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class updatebase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Traders_perfilTraders_PerfilTraderID",
                table: "Traders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_perfilTraders",
                table: "perfilTraders");

            migrationBuilder.RenameTable(
                name: "perfilTraders",
                newName: "PerfilTraders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerfilTraders",
                table: "PerfilTraders",
                column: "PerfilTraderID");

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
                name: "FK_Traders_PerfilTraders_PerfilTraderID",
                table: "Traders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerfilTraders",
                table: "PerfilTraders");

            migrationBuilder.RenameTable(
                name: "PerfilTraders",
                newName: "perfilTraders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_perfilTraders",
                table: "perfilTraders",
                column: "PerfilTraderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Traders_perfilTraders_PerfilTraderID",
                table: "Traders",
                column: "PerfilTraderID",
                principalTable: "perfilTraders",
                principalColumn: "PerfilTraderID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
