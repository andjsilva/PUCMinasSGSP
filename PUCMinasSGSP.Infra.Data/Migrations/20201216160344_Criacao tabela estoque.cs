using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PUCMinasSGSP.Infra.Data.Migrations
{
    public partial class Criacaotabelaestoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produto");

            migrationBuilder.AddColumn<string>(
                name: "Fabricante",
                table: "Produto",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdFabricante",
                table: "Produto",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    IdProduto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUnidadeAtendimento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantidade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => new { x.IdProduto, x.IdUnidadeAtendimento });
                    table.ForeignKey(
                        name: "FK_Estoque_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estoque_UnidadeAtendimento_IdUnidadeAtendimento",
                        column: x => x.IdUnidadeAtendimento,
                        principalTable: "UnidadeAtendimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_IdUnidadeAtendimento",
                table: "Estoque",
                column: "IdUnidadeAtendimento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropColumn(
                name: "Fabricante",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "IdFabricante",
                table: "Produto");

            migrationBuilder.AddColumn<double>(
                name: "Quantidade",
                table: "Produto",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
