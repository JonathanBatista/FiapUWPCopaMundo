using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fiap.CopaMundo.EntityFramework.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Identificador = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabela",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Derrotas = table.Column<short>(nullable: false),
                    Empates = table.Column<short>(nullable: false),
                    Jogos = table.Column<short>(nullable: false),
                    Pontuacao = table.Column<short>(nullable: false),
                    SaldoGols = table.Column<decimal>(nullable: false),
                    Vitorias = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(maxLength: 10, nullable: true),
                    NomeExibicao = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Estadio = table.Column<string>(nullable: true),
                    GrupoId = table.Column<int>(nullable: false),
                    Horario = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partida_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Selecao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bandeira = table.Column<string>(maxLength: 50, nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    GrupoId = table.Column<int>(nullable: false),
                    Pais = table.Column<string>(maxLength: 25, nullable: true),
                    TabelaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selecao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Selecao_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Selecao_Tabela_TabelaId",
                        column: x => x.TabelaId,
                        principalTable: "Tabela",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Configuracao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Notificar = table.Column<bool>(nullable: false),
                    SelecaoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Configuracao_Selecao_SelecaoId",
                        column: x => x.SelecaoId,
                        principalTable: "Selecao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configuracao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Altura = table.Column<decimal>(nullable: false),
                    Idade = table.Column<short>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    QuantidadeGols = table.Column<short>(nullable: false),
                    SelecaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogador_Selecao_SelecaoId",
                        column: x => x.SelecaoId,
                        principalTable: "Selecao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartidaDetalhe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Formacao = table.Column<string>(maxLength: 10, nullable: true),
                    GolsMarcados = table.Column<short>(nullable: false),
                    PartidaId = table.Column<int>(nullable: false),
                    QuantidadeSubstituicoes = table.Column<short>(nullable: false),
                    SelecaoId = table.Column<int>(nullable: false),
                    Vencedor = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartidaDetalhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartidaDetalhe_Partida_PartidaId",
                        column: x => x.PartidaId,
                        principalTable: "Partida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartidaDetalhe_Selecao_SelecaoId",
                        column: x => x.SelecaoId,
                        principalTable: "Selecao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JogadorPartidaDetalhe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CartaoAmarelo = table.Column<short>(nullable: false),
                    CartaoVermelho = table.Column<short>(nullable: false),
                    Gols = table.Column<short>(nullable: false),
                    JogadorId = table.Column<int>(nullable: false),
                    NumeroCamisa = table.Column<short>(nullable: false),
                    PartidaDetalheId = table.Column<int>(nullable: false),
                    Posicao = table.Column<string>(maxLength: 3, nullable: true),
                    SubstitutoId = table.Column<int>(nullable: true),
                    Titular = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogadorPartidaDetalhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JogadorPartidaDetalhe_Jogador_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogadorPartidaDetalhe_PartidaDetalhe_PartidaDetalheId",
                        column: x => x.PartidaDetalheId,
                        principalTable: "PartidaDetalhe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogadorPartidaDetalhe_JogadorPartidaDetalhe_SubstitutoId",
                        column: x => x.SubstitutoId,
                        principalTable: "JogadorPartidaDetalhe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Configuracao_SelecaoId",
                table: "Configuracao",
                column: "SelecaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Configuracao_UsuarioId",
                table: "Configuracao",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_SelecaoId",
                table: "Jogador",
                column: "SelecaoId");

            migrationBuilder.CreateIndex(
                name: "IX_JogadorPartidaDetalhe_JogadorId",
                table: "JogadorPartidaDetalhe",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_JogadorPartidaDetalhe_PartidaDetalheId",
                table: "JogadorPartidaDetalhe",
                column: "PartidaDetalheId");

            migrationBuilder.CreateIndex(
                name: "IX_JogadorPartidaDetalhe_SubstitutoId",
                table: "JogadorPartidaDetalhe",
                column: "SubstitutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_GrupoId",
                table: "Partida",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidaDetalhe_PartidaId",
                table: "PartidaDetalhe",
                column: "PartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidaDetalhe_SelecaoId",
                table: "PartidaDetalhe",
                column: "SelecaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Selecao_GrupoId",
                table: "Selecao",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Selecao_TabelaId",
                table: "Selecao",
                column: "TabelaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracao");

            migrationBuilder.DropTable(
                name: "JogadorPartidaDetalhe");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Jogador");

            migrationBuilder.DropTable(
                name: "PartidaDetalhe");

            migrationBuilder.DropTable(
                name: "Partida");

            migrationBuilder.DropTable(
                name: "Selecao");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Tabela");
        }
    }
}
