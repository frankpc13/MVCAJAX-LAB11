namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studentLastName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "studentCode", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "UpdatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "UpdatedAt");
            DropColumn("dbo.Students", "CreatedAt");
            DropColumn("dbo.Students", "studentCode");
            DropColumn("dbo.Students", "studentLastName");
        }
    }
}
