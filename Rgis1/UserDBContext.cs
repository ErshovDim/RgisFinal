using Microsoft.EntityFrameworkCore;

namespace RGIS
{
    public class UserDBContext : DbContext
    {
      
            public DbSet<Knjiga> kniznica { get; set; }
            public string Dbpath { get; }

            public UserDBContext()
            {

                string startupPath = System.IO.Directory.GetCurrentDirectory();
                Dbpath = System.IO.Path.Join(startupPath, "KniznicaDb.db");

            //Database.EnsureDeleted();

            //if (!File.Exists(Dbpath))
            //{
            

            //}
        }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite($"Data Source = {Dbpath}");
            }

        
    }
}
