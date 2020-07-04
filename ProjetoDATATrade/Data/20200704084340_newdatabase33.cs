﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDATATrade.Data
{
    public partial class newdatabase33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes");

            migrationBuilder.AlterColumn<int>(
                name: "EstrategiaID",
                table: "Operacoes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OperacaoID",
                table: "Estrategias",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Operacoes_Estrategias_EstrategiaID",
                table: "Operacoes",
                column: "EstrategiaID",
                principalTable: "Estrategias",
                principalColumn: "EstrategiaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
