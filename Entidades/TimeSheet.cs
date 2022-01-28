using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class TimeSheet : Entity
    {
        public string NomeDev { get; set; }
        public string EmailDev { get; set; }
        public string EmailUpload { get; set; }
        public DateTime DataUpload { get; set; }
        public string Cliente { get; set; }
        public string Telefone { get; set; }
        public string Projeto { get; set; }
        public string Tipo { get; set; }
        public string Observacao { get; set; }
        public string Total { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public string EmailDoColaborador { get; set; }
        public string TipoAtivo { get; set; }
        public string IdProjeto { get; set; }

        [NotMapped]
        public IFormFile Arquivo { get; set; }
    }
}
