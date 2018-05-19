﻿// <auto-generated />
using Fiap.CopaMundo.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Fiap.CopaMundo.EntityFramework.Migrations
{
    [DbContext(typeof(CopaMundoContext))]
    [Migration("20180519180352_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Configuracao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Notificar");

                    b.Property<int>("SelecaoId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("SelecaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Configuracao");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Identificador")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Altura");

                    b.Property<short>("Idade");

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.Property<short>("QuantidadeGols");

                    b.Property<int>("SelecaoId");

                    b.HasKey("Id");

                    b.HasIndex("SelecaoId");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.JogadorPartidaDetalhe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("CartaoAmarelo");

                    b.Property<short>("CartaoVermelho");

                    b.Property<short>("Gols");

                    b.Property<int>("JogadorId");

                    b.Property<short>("NumeroCamisa");

                    b.Property<int>("PartidaDetalheId");

                    b.Property<string>("Posicao")
                        .HasMaxLength(3);

                    b.Property<int?>("SubstitutoId");

                    b.Property<bool>("Titular");

                    b.HasKey("Id");

                    b.HasIndex("JogadorId");

                    b.HasIndex("PartidaDetalheId");

                    b.HasIndex("SubstitutoId");

                    b.ToTable("JogadorPartidaDetalhe");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Partida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Estadio");

                    b.Property<int>("GrupoId");

                    b.Property<DateTime>("Horario");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.ToTable("Partida");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.PartidaDetalhe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Formacao")
                        .HasMaxLength(10);

                    b.Property<short>("GolsMarcados");

                    b.Property<int>("PartidaId");

                    b.Property<short>("QuantidadeSubstituicoes");

                    b.Property<int>("SelecaoId");

                    b.Property<bool>("Vencedor");

                    b.HasKey("Id");

                    b.HasIndex("PartidaId");

                    b.HasIndex("SelecaoId");

                    b.ToTable("PartidaDetalhe");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Selecao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bandeira")
                        .HasMaxLength(50);

                    b.Property<bool>("Eliminado");

                    b.Property<int>("GrupoId");

                    b.Property<string>("Pais")
                        .HasMaxLength(25);

                    b.Property<int>("TabelaId");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("TabelaId");

                    b.ToTable("Selecao");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Tabela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("Derrotas");

                    b.Property<short>("Empates");

                    b.Property<short>("Jogos");

                    b.Property<short>("Pontuacao");

                    b.Property<decimal>("SaldoGols");

                    b.Property<short>("Vitorias");

                    b.HasKey("Id");

                    b.ToTable("Tabela");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login")
                        .HasMaxLength(10);

                    b.Property<string>("NomeExibicao")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Configuracao", b =>
                {
                    b.HasOne("Fiap.CopaMundo.Core.Models.Selecao", "Selecao")
                        .WithMany("Configuracoes")
                        .HasForeignKey("SelecaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fiap.CopaMundo.Core.Models.Usuario", "Usuario")
                        .WithMany("Configuracoes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Jogador", b =>
                {
                    b.HasOne("Fiap.CopaMundo.Core.Models.Selecao", "Selecao")
                        .WithMany("Jogadores")
                        .HasForeignKey("SelecaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.JogadorPartidaDetalhe", b =>
                {
                    b.HasOne("Fiap.CopaMundo.Core.Models.Jogador", "Jogador")
                        .WithMany("Partidas")
                        .HasForeignKey("JogadorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fiap.CopaMundo.Core.Models.PartidaDetalhe", "PartidaDetalhe")
                        .WithMany("Jogadores")
                        .HasForeignKey("PartidaDetalheId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fiap.CopaMundo.Core.Models.JogadorPartidaDetalhe", "Substituto")
                        .WithMany()
                        .HasForeignKey("SubstitutoId");
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Partida", b =>
                {
                    b.HasOne("Fiap.CopaMundo.Core.Models.Grupo", "Grupo")
                        .WithMany("Partidas")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.PartidaDetalhe", b =>
                {
                    b.HasOne("Fiap.CopaMundo.Core.Models.Partida", "Partida")
                        .WithMany("Detalhes")
                        .HasForeignKey("PartidaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fiap.CopaMundo.Core.Models.Selecao", "Selecao")
                        .WithMany("Partidas")
                        .HasForeignKey("SelecaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fiap.CopaMundo.Core.Models.Selecao", b =>
                {
                    b.HasOne("Fiap.CopaMundo.Core.Models.Grupo", "Grupo")
                        .WithMany("Selecoes")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fiap.CopaMundo.Core.Models.Tabela", "Tabela")
                        .WithMany()
                        .HasForeignKey("TabelaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
