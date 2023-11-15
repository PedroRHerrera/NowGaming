using Microsoft.EntityFrameworkCore;
using NowGaming.Models.Entities;

namespace NowGaming.Models
{
    public class Context:DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\Servidor; Initial Catalog=NowGamingDB; Integrated Security=true; Encrypt=false; TrustServerCertificate=true");
        }
    }
}
