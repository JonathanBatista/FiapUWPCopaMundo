using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.CopaMundo.UWP.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> ListarTodos();

        IEnumerable<T> ListarTodos(Func<T, bool> expression);

        IEnumerable<T> ListarTodosCompleto();

        IEnumerable<T> ListarTodosCompleto(Func<T, bool> expression);
        
        T Obter(Func<T, bool> expression);
    }
}
