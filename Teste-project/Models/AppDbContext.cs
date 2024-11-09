using Microsoft.EntityFrameworkCore;

namespace Teste_project.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Alimento> Alimentos {  get; set; }  
    }
}
