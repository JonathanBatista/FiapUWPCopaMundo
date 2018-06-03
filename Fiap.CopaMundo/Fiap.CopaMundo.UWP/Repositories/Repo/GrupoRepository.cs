using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Fiap.CopaMundo.Core.Models;
using Fiap.CopaMundo.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Fiap.CopaMundo.UWP.Repositories.Repo
{
    public class GrupoRepository : IRepository<Grupo>
    {

        public IEnumerable<Grupo> ListarTodos()
        {        
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Grupos.ToList();
            }            
        }

        public IEnumerable<Grupo> ListarTodos(Func<Grupo, bool> expression)
        {
            using (var ctx = new CopaMundoContext())
            {
                var grupos = ctx.Grupos
                    .Where(expression)
                    .ToList();

                return grupos;
            } 
        }

        public IEnumerable<Grupo> ListarTodosCompleto()
        {
            using (var ctx = new CopaMundoContext())
            {
                var grupos = ctx.Grupos
                    .Include(grupo => grupo.Selecoes)
                        .ThenInclude(selecoes => selecoes.Tabela)
                    .Include(x => x.Partidas)
                    .ToList();

                return grupos;
            }
        }

        public IEnumerable<Grupo> ListarTodosCompleto(Func<Grupo, bool> expression)
        {
            using (var ctx = new CopaMundoContext())
            {
                var grupos = ctx.Grupos
                    .Include(grupo => grupo.Selecoes)
                        .ThenInclude(selecoes => selecoes.Tabela)
                    .Include(x => x.Partidas)
                    .Where(expression)
                    .ToList();

                return grupos;
            }
        }

        public Grupo Obter(Func<Grupo, bool> expression)
        {
            using (var ctx = new CopaMundoContext())
            {
                return ctx.Grupos
                    .Include(grupo => grupo.Selecoes)
                        .ThenInclude(selecoes => selecoes.Tabela)
                    .Include(x => x.Partidas)
                    .FirstOrDefault(expression);
            }
        }
    }
}
