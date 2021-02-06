using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PUCMinasSGSP.Infra.Data.Migrations
{
    public partial class Prontuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Prontuario_IdProntuario",
                table: "Paciente");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdProntuario",
                table: "Paciente",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Prontuario_IdProntuario",
                table: "Paciente",
                column: "IdProntuario",
                principalTable: "Prontuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Prontuario_IdProntuario",
                table: "Paciente");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdProntuario",
                table: "Paciente",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Prontuario_IdProntuario",
                table: "Paciente",
                column: "IdProntuario",
                principalTable: "Prontuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
