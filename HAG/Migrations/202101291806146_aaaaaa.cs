namespace HAG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaaaa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "lastName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "lastName", c => c.Long(nullable: false));
        }
    }
}
