using Microsoft.EntityFrameworkCore;
using ProyectoWebApi.Entities;

namespace ProyectoWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Autores> Autores { get; set; }
    }
}
