namespace CocoFarm.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescriptionRequired : DbMigration
    {
        public override void Up()
        {
            this.Sql(@"update Products set Denumire = N'' where Denumire is null
update Products set Cod = N'' where Cod is null");

            AlterColumn("dbo.Products", "Denumire", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Cod", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Cod", c => c.String());
            AlterColumn("dbo.Products", "Denumire", c => c.String());
        }
    }
}
