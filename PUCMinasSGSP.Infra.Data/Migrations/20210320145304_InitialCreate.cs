using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PUCMinasSGSP.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
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
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedimento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdFabricante = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UnidadeMedida = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prontuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    TipoSanguinio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RhSanguinio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlergiasMedicacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doencas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prontuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeAtendimento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeAtendimento", x => x.Id);
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
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdPessoa = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_Pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdProntuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Paciente_Prontuario_IdProntuario",
                        column: x => x.IdProntuario,
                        principalTable: "Prontuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Campanha",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUnidadeAtendimento = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campanha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campanha_UnidadeAtendimento_IdUnidadeAtendimento",
                        column: x => x.IdUnidadeAtendimento,
                        principalTable: "UnidadeAtendimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Leito",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    IdUnidadeAtendimento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leito_UnidadeAtendimento_IdUnidadeAtendimento",
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
                name: "Diagnostico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    IdProntuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUnidadeAtendimento = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnostico_Funcionario_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnostico_Prontuario_IdProntuario",
                        column: x => x.IdProntuario,
                        principalTable: "Prontuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diagnostico_UnidadeAtendimento_IdUnidadeAtendimento",
                        column: x => x.IdUnidadeAtendimento,
                        principalTable: "UnidadeAtendimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Internacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProntuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLeito = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Alta = table.Column<bool>(type: "bit", nullable: false),
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Internacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Internacao_Funcionario_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Internacao_Leito_IdLeito",
                        column: x => x.IdLeito,
                        principalTable: "Leito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Internacao_Prontuario_IdProntuario",
                        column: x => x.IdProntuario,
                        principalTable: "Prontuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalhesProntuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProntuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInternacao = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncionarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Solicitacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Execucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdProcedimento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDiagnostico = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhesProntuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalhesProntuario_Diagnostico_IdDiagnostico",
                        column: x => x.IdDiagnostico,
                        principalTable: "Diagnostico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalhesProntuario_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalhesProntuario_Internacao_IdInternacao",
                        column: x => x.IdInternacao,
                        principalTable: "Internacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalhesProntuario_Procedimento_IdProcedimento",
                        column: x => x.IdProcedimento,
                        principalTable: "Procedimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalhesProntuario_Prontuario_IdProntuario",
                        column: x => x.IdProntuario,
                        principalTable: "Prontuario",
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
                name: "IX_Campanha_IdUnidadeAtendimento",
                table: "Campanha",
                column: "IdUnidadeAtendimento");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhesProntuario_FuncionarioId",
                table: "DetalhesProntuario",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhesProntuario_IdDiagnostico",
                table: "DetalhesProntuario",
                column: "IdDiagnostico");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhesProntuario_IdInternacao",
                table: "DetalhesProntuario",
                column: "IdInternacao");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhesProntuario_IdProcedimento",
                table: "DetalhesProntuario",
                column: "IdProcedimento");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhesProntuario_IdProntuario",
                table: "DetalhesProntuario",
                column: "IdProntuario");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostico_IdProntuario",
                table: "Diagnostico",
                column: "IdProntuario");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostico_IdUnidadeAtendimento",
                table: "Diagnostico",
                column: "IdUnidadeAtendimento");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostico_MedicoId",
                table: "Diagnostico",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_IdPessoa",
                table: "Documento",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Email_IdPessoa",
                table: "Email",
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
                name: "IX_Estoque_IdUnidadeAtendimento",
                table: "Estoque",
                column: "IdUnidadeAtendimento");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_IdCargo",
                table: "Funcionario",
                column: "IdCargo");

            migrationBuilder.CreateIndex(
                name: "IX_Internacao_IdLeito",
                table: "Internacao",
                column: "IdLeito");

            migrationBuilder.CreateIndex(
                name: "IX_Internacao_IdMedico",
                table: "Internacao",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Internacao_IdProntuario",
                table: "Internacao",
                column: "IdProntuario");

            migrationBuilder.CreateIndex(
                name: "IX_Leito_IdUnidadeAtendimento",
                table: "Leito",
                column: "IdUnidadeAtendimento");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdProntuario",
                table: "Paciente",
                column: "IdProntuario",
                unique: true,
                filter: "[IdProntuario] IS NOT NULL");

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
                name: "Campanha");

            migrationBuilder.DropTable(
                name: "DetalhesProntuario");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "EspecialidadeFuncionario");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Diagnostico");

            migrationBuilder.DropTable(
                name: "Internacao");

            migrationBuilder.DropTable(
                name: "Procedimento");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Leito");

            migrationBuilder.DropTable(
                name: "Prontuario");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "UnidadeAtendimento");
        }
    }
}
