
using Microsoft.EntityFrameworkCore;
using Transportadora.Entidades;

namespace Transportadora.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Origem> Origens { get; set; }
        public DbSet<Terminal> Terminais { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
