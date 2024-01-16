using ActividadGS.Models;
using Microsoft.EntityFrameworkCore;

namespace ActividadGS
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
