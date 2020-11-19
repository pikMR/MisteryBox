namespace MisteryBoxInfraestructure.Migrations
{
    using System.Data.Entity.Migrations;
    using MisteryBoxInfraestructure.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            //CreateFakeElements.CreateFakesInDB(); -> uncomment for create database with mock elements
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context context)
        {
            CreateFakeElements.CreateFakesInDB();
        }
    }
}
