using System.Data.Entity;
using CocoFarm.Model;

namespace CocoFarm.DataAccess
{
    public class CocoFarmContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
    }
}
