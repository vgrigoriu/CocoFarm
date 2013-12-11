using CocoFarm.Model;

namespace CocoFarm.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CocoFarm.DataAccess.CocoFarmContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CocoFarm.DataAccess.CocoFarmContext";
        }

        protected override void Seed(CocoFarmContext context)
        {
            context.Categories.AddOrUpdate(p => p.Name,
                new ProductCategory() { Id = Guid.NewGuid(), Name = "Antibiotics" },
                new ProductCategory() { Id = Guid.NewGuid(), Name = "First Aid" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
