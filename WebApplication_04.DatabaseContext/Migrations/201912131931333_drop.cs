namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class drop : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "AdmissionTests_Id", "dbo.AdmissionTests");
            DropIndex("dbo.Students", new[] { "AdmissionTests_Id" });
            DropColumn("dbo.Students", "AdmissionTestId");
            DropColumn("dbo.Students", "AdmissionTests_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "AdmissionTests_Id", c => c.Int());
            AddColumn("dbo.Students", "AdmissionTestId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "AdmissionTests_Id");
            AddForeignKey("dbo.Students", "AdmissionTests_Id", "dbo.AdmissionTests", "Id");
        }
    }
}
