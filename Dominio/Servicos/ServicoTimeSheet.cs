using Dominio.Interfaces.Genericas;
using Entidades;
using Infraestrutura.Configuracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class ServicoTimeSheet
    {
        private readonly Contexto _contexto;
        public ServicoTimeSheet(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool CreateTimeSheet(TimeSheet timeSheet)
        {
            try
            {
                _contexto.TimeSheet.AddAsync(timeSheet);
                _contexto.SaveChangesAsync();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteTimeSheet(TimeSheet timeSheet)
        {
            try
            {
                _contexto.Remove(timeSheet);
                _contexto.SaveChangesAsync();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public TimeSheet Get_TimeSheet(Guid id)
        {
            return _contexto.TimeSheet.FirstOrDefault(t => t.Id == id);
        }

        public bool EditTimeSheet(TimeSheet timeSheet)
        {
            try
            {
                _contexto.TimeSheet.Update(timeSheet);
                _contexto.SaveChangesAsync();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<TimeSheet> List_TimeSheet(string busca = null)
        {
            return _contexto.TimeSheet.ToList();
        }
    }
}
