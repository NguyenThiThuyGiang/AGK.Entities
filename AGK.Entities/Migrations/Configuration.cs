namespace AGK.Entities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AGK.Entities.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations";
            
        }

        protected override void Seed(AGK.Entities.ProductDbContext context)
        {
            var pro = new Product()
            {
                Name = "Nhật Khoa",
                Category = new Category() { Name = "Khoa" },
                Manufacturer = new Manufacturer() { Name = "khoasad" }
            };
            context.Products.Add(pro);
            context.SaveChanges();
        }
    }
}
