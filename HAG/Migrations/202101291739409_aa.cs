namespace HAG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.Long(nullable: false),
                        address = c.String(),
                        phone = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
