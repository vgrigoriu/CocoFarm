namespace CocoFarm.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Denumire = c.String(),
                        Cod = c.String(),
                        Descriere = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produs");
        }
    }
}
