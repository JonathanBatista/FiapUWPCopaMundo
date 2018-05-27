using Fiap.CopaMundo.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Fiap.CopaMundo.EntityFramework.Contexts
{
    public class CopaMundoContext : DbContext
    {
       

        public DbSet<Configuracao> Configuracoes { get; set; }

        public DbSet<Grupo> Grupos { get; set; }

        public DbSet<Jogador> Jogadores { get; set; }

        public DbSet<JogadorPartidaDetalhe> JogadorPartidaDetalhes { get; set; }

        public DbSet<Partida> Partidas { get; set; }

        public DbSet<PartidaDetalhe> PartidaDetalhes { get; set; }

        public DbSet<Selecao> Selecoes { get; set; }

        public DbSet<Tabela> Tabelas { get; set; }

        public DbSet<Usuario> Usuario { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={Environment.CurrentDirectory}\\..\\Fiap.CopaMundo.EntityFramework\\Migrations\\Database\\copamundo.db");
        }
    }
}
