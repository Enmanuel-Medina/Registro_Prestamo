
using Microsoft.EntityFrameworkCore;
using Registro_Pago.Entidades;

namespace Registro_Pago.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\Personas.db");
        }
    }
 }
