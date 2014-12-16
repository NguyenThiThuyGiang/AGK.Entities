namespace AGK.Entities.MiCustomer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AGK.Entities.CustomerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"MiCustomer";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AGK.Entities.CustomerDbContext context)
        {
            
        }
    }
}
