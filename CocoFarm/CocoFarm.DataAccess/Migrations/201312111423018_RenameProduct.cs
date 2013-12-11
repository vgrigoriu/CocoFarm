namespace CocoFarm.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameProduct : DbMigration
    {
        public override void Up()
        {
            RenameTable("dbo.Produs", "Products");
        }
        
        public override void Down()
        {
            RenameTable("dbo.Products", "Produs");
        }
    }
}
