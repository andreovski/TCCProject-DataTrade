using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompleto = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Carteiras",
                columns: table => new
                {
                    CarteiraID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(nullable: false),
                    Saldo = table.Column<float>(nullable: false),
                    TempoInvestimento = table.Column<DateTime>(nullable: false),
                    InvestimentoMensal = table.Column<float>(nullable: false),
                    TotalAcumulado = table.Column<float>(nullable: false),
                    Lucro = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carteiras", x => x.CarteiraID);
                    table.ForeignKey(
                        name: "FK_Carteiras_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estrategias",
                columns: table => new
                {
                    EstrategiaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(nullable: false),
                    NomeEstrategia = table.Column<string>(nullable: false),
                    Onde = table.Column<string>(nullable: false),
                    Como = table.Column<string>(nullable: false),
                    Porque = table.Column<string>(nullable: false),
                    Quando = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estrategias", x => x.EstrategiaID);
                    table.ForeignKey(
                        name: "FK_Estrategias_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operacoes",
                columns: table => new
                {
                    OperacaoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(nullable: false),
                    Ativo = table.Column<string>(nullable: false),
                    Estrategia = table.Column<string>(nullable: false),
                    DataeHora = table.Column<string>(nullable: false),
                    Carteira = table.Column<float>(nullable: false),
                    Risco = table.Column<float>(nullable: false),
                    PrecoEntrada = table.Column<float>(nullable: false),
                    TakeProfit = table.Column<float>(nullable: false),
                    StopLoss = table.Column<float>(nullable: false),
                    Resultado = table.Column<float>(nullable: false),
                    Ordem = table.Column<string>(nullable: false),
                    Lote = table.Column<float>(nullable: false),
                    NumeroOperacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operacoes", x => x.OperacaoID);
                    table.ForeignKey(
                        name: "FK_Operacoes_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Traders",
                columns: table => new
                {
                    TraderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(nullable: false),
                    PerfilTrader = table.Column<string>(nullable: false),
                    DiasOperacao = table.Column<string>(nullable: false),
                    HorarioOperacao = table.Column<string>(nullable: false),
                    ObjetivoGanhoDiario = table.Column<float>(nullable: false),
                    ObjetivoGanhoSemanal = table.Column<float>(nullable: false),
                    ObjetivoGanhoMensal = table.Column<float>(nullable: false),
                    LimitePerdaDiaria = table.Column<float>(nullable: false),
                    LimitePerdaSemanal = table.Column<float>(nullable: false),
                    LimitePerdaMensal = table.Column<float>(nullable: false),
                    AtivoOperado = table.Column<string>(nullable: false),
                    Indicadores = table.Column<string>(nullable: false),
                    PrincipaisCandle = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traders", x => x.TraderID);
                    table.ForeignKey(
                        name: "FK_Traders_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carteiras_UsuarioID",
                table: "Carteiras",
                column: "UsuarioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estrategias_UsuarioID",
                table: "Estrategias",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Operacoes_UsuarioID",
                table: "Operacoes",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_UsuarioID",
                table: "Traders",
                column: "UsuarioID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carteiras");

            migrationBuilder.DropTable(
                name: "Estrategias");

            migrationBuilder.DropTable(
                name: "Operacoes");

            migrationBuilder.DropTable(
                name: "Traders");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
