using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PUCMinasSGSP.Infra.Data.Migrations
{
    public partial class Fase1_Desenho_Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdPessoa = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documento_Pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paciente_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeAtendimento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipox = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeAtendimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Admissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdCargo = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionario_Cargo_IdCargo",
                        column: x => x.IdCargo,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionario_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoLogradouro = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longetude = table.Column<double>(type: "float", nullable: false),
                    IdPessoa = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUnidadeAtendimento = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_UnidadeAtendimento_IdUnidadeAtendimento",
                        column: x => x.IdUnidadeAtendimento,
                        principalTable: "UnidadeAtendimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    DDI = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    DDD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Recado = table.Column<bool>(type: "bit", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdPessoa = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUnidadeAtendimento = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnidadeAtendimentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefone_Pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefone_UnidadeAtendimento_UnidadeAtendimentoId",
                        column: x => x.UnidadeAtendimentoId,
                        principalTable: "UnidadeAtendimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    DiaSemana = table.Column<int>(type: "int", nullable: false),
                    Entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdFuncionario = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agenda_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EspecialidadeFuncionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEspecialidade = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdFuncionario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadeFuncionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EspecialidadeFuncionario_Especialidade_IdEspecialidade",
                        column: x => x.IdEspecialidade,
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadeFuncionario_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_IdFuncionario",
                table: "Agenda",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_IdPaciente",
                table: "Agenda",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_IdPessoa",
                table: "Documento",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdPessoa",
                table: "Endereco",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdUnidadeAtendimento",
                table: "Endereco",
                column: "IdUnidadeAtendimento",
                unique: true,
                filter: "[IdUnidadeAtendimento] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadeFuncionario_IdEspecialidade",
                table: "EspecialidadeFuncionario",
                column: "IdEspecialidade");

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadeFuncionario_IdFuncionario",
                table: "EspecialidadeFuncionario",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_IdCargo",
                table: "Funcionario",
                column: "IdCargo");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_IdPessoa",
                table: "Telefone",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_UnidadeAtendimentoId",
                table: "Telefone",
                column: "UnidadeAtendimentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "EspecialidadeFuncionario");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "UnidadeAtendimento");

            migrationBuilder.DropTable(
                name: "Cargo");
        }
    }
}
