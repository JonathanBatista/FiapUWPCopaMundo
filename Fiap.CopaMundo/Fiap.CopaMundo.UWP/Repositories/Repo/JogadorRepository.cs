using Fiap.CopaMundo.Core.Models;
using Fiap.CopaMundo.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.CopaMundo.UWP.Repositories.Repo
{
    public class JogadorRepository : IRepository<Jogador>
    {
        public IEnumerable<Jogador> ListarTodos()
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Jogadores.ToList();
            }
        }

        public IEnumerable<Jogador> ListarTodos(Func<Jogador, bool> expression)
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Jogadores
                        .Where(expression).ToList();
            };
        }

        public IEnumerable<Jogador> ListarTodosCompleto()
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Jogadores
                        .Include(x => x.Selecao)
                        .Include(x => x.Partidas)
                        .ToList();
            }
        }

        public IEnumerable<Jogador> ListarTodosCompleto(Func<Jogador, bool> expression)
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Jogadores
                        .Include(x => x.Selecao)
                        .Include(x => x.Partidas)
                        .Where(expression).ToList();
            }
        }

        public Jogador Obter(Func<Jogador, bool> expression)
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Jogadores
                        .Include(x => x.Selecao)
                        .Include(x => x.Partidas)
                        .FirstOrDefault(expression);
            }
        }
    }
}
