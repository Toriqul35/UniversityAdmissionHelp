namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "IsEmailVerified", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "IsEmailVerified");
        }
    }
}
