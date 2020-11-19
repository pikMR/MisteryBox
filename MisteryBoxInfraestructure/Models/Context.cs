using MisteryBoxInfraestructure.Migrations;
using MisteryBoxDomain.Entities;
using System.Data.Entity;

namespace MisteryBoxInfraestructure.Data
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public DbSet<Cocina> Cocinas { get; set; }
        public DbSet<Ropa> Ropas { get; set; }

        public void MigrateElements()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }
    }
}
