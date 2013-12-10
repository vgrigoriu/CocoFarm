namespace CocoFarm.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produs", "Price", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produs", "Price");
        }
    }
}
