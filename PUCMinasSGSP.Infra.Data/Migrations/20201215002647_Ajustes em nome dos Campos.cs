using Microsoft.EntityFrameworkCore.Migrations;

namespace PUCMinasSGSP.Infra.Data.Migrations
{
    public partial class AjustesemnomedosCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipox",
                table: "UnidadeAtendimento",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "TipoLogradouro",
                table: "Endereco",
                newName: "Tipo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "UnidadeAtendimento",
                newName: "Tipox");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Endereco",
                newName: "TipoLogradouro");
        }
    }
}
