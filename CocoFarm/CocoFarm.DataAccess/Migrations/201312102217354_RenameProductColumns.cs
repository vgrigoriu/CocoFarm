namespace CocoFarm.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameProductColumns : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Products", "Denumire", "Name");
            RenameColumn("dbo.Products", "Cod", "Code");
            RenameColumn("dbo.Products", "Descriere", "Description");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Products", "Name", "Denumire");
            RenameColumn("dbo.Products", "Code", "Cod");
            RenameColumn("dbo.Products", "Description", "Descriere");
        }
    }
}
