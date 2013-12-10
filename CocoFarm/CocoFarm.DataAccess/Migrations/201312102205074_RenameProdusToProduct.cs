namespace CocoFarm.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameProdusToProduct : DbMigration
    {
        public override void Up()
        {
            RenameTable("Produs", "Products");
        }
        
        public override void Down()
        {
            RenameTable("Products", "Produs");
        }
    }
}
