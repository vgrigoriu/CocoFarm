using System.Data.Entity;
using CocoFarm.Model;

namespace CocoFarm.DataAccess
{
    public class CocoFarmContext : DbContext
    {
        DbSet<Produs> Products { get; set; }
    }
}
