using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace RGIS
{
    public class KnjigaDbContext : DbContext
    {
        public DbSet<Knjiga> knjigas { get; set; }
        public string Dbpath { get; }

        public KnjigaDbContext()
        {

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            Dbpath = System.IO.Path.Join(startupPath, "KnigaDb.db");
            //Database.EnsureDeleted();
            //Database.EnsureCreated();

           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {Dbpath}");
        }

    }
}
