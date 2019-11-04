namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "CreatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Students", "UpdatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "UpdatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "CreatedAt", c => c.DateTime(nullable: false));
        }
    }
}
