using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Configuracoes
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {
        }
        public DbSet<TimeSheet> TimeSheet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConnection());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public string ObterStringConnection()
        {
           return "Server=(localdb)\\mssqllocaldb;Database=DDD_Tests_Db;Trusted_Connection=True;MultipleActiveResultSets=true";
        }
    }
}
