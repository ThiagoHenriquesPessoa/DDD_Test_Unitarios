using Dominio.Interfaces;
using Dominio.Servicos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{    
    public class Repositorio : IRepositorio
    {
        private readonly ServicoTimeSheet _servicoTimeSheet;
        public Repositorio(ServicoTimeSheet servicoTimeSheet)
        {
            _servicoTimeSheet = servicoTimeSheet;
        }
        public bool Create(TimeSheet timeSheet)
        {
            return _servicoTimeSheet.CreateTimeSheet(timeSheet);
        }

        public Task Delete(TimeSheet Objeto)
        {
            throw new NotImplementedException();
        }

        public Task Details(TimeSheet Objeto)
        {
            throw new NotImplementedException();
        }

        public Task Edit(TimeSheet Objeto)
        {
            throw new NotImplementedException();
        }

        public Task Index(TimeSheet Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
