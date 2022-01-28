using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces.Genericas
{
    public interface IGenericas<T> where T : class
    {
        Task Index(T Objeto);
        Task Create(T Objeto);
        Task Edit(T Objeto);
        Task Delete(T Objeto);
        Task Details(T Objeto);
    }
}
