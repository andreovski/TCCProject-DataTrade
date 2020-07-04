using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class newdatabas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiasOperacao",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "HorarioOperacao",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "PerfilTraders");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "NomeEstrategia",
                table: "Estrategias");

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
                name: "Nome",
                table: "PerfilTraders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Indicadores",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Estrategias",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiasTrader",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "HorarioTrader",
                table: "Traders");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "PerfilTraders");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Indicadores");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Estrategias");

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
                name: "Titulo",
                table: "PerfilTraders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Indicadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeEstrategia",
                table: "Estrategias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
