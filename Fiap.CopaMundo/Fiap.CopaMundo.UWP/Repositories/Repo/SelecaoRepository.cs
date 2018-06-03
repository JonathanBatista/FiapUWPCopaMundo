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
    public class SelecaoRepository : IRepository<Selecao>
    {
        public IEnumerable<Selecao> ListarTodos()
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Selecoes;
            }
        }

        public IEnumerable<Selecao> ListarTodos(Func<Selecao, bool> expression)
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Selecoes.Where(expression).ToList();
            };
        }

        public IEnumerable<Selecao> ListarTodosCompleto()
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Selecoes
                            .Include(x => x.Jogadores)
                            .Include(x => x.Tabela)
                            .Include(x => x.Grupo)
                            .ToList();
            }
        }

        public IEnumerable<Selecao> ListarTodosCompleto(Func<Selecao, bool> expression)
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Selecoes
                            .Include(x => x.Jogadores)
                            .Include(x => x.Tabela)
                            .Include(x => x.Grupo)
                            .Where(expression)
                            .ToList();
            }
        }

        public Selecao Obter(Func<Selecao, bool> expression)
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Selecoes
                            .Include(x => x.Jogadores)
                            .Include(x => x.Tabela)
                            .Include(x => x.Grupo)
                            .FirstOrDefault(expression);
            }
        }
    }
}
