using BarrancoNacano.Models;
using Microsoft.EntityFrameworkCore;

namespace BarrancoNacano.Models
{
    public class DbContextApp : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=prestamos.db");
        }
    }
}
