using Microsoft.EntityFrameworkCore;
using NWSInventaire.Server.Models;

namespace NWSInventaire.Server.Data
{
    public class DataContext : DbContext
    {
        public static bool Migrated;

        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }


        public DbSet<Material>? materials { get; set; }

        public DbSet<Student>? students { get; set; }

    }
}
