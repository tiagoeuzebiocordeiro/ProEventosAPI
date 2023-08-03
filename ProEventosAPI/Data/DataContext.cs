using Microsoft.EntityFrameworkCore;
using ProEventosAPI.Models;

namespace ProEventosAPI.Data {
    public class DataContext : DbContext{

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }

    }
}
