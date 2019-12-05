namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Students : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "DateOfBirth1", c => c.String());
            AddColumn("dbo.Students", "Address1", c => c.String());
            AddColumn("dbo.Students", "Address2", c => c.String());
            AddColumn("dbo.Students", "Country", c => c.String());
            AddColumn("dbo.Students", "State", c => c.String());
            DropColumn("dbo.Students", "ContactPerson");
            DropColumn("dbo.Students", "Address");
            DropColumn("dbo.Students", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Image", c => c.String());
            AddColumn("dbo.Students", "Address", c => c.String());
            AddColumn("dbo.Students", "ContactPerson", c => c.String());
            DropColumn("dbo.Students", "State");
            DropColumn("dbo.Students", "Country");
            DropColumn("dbo.Students", "Address2");
            DropColumn("dbo.Students", "Address1");
            DropColumn("dbo.Students", "DateOfBirth1");
        }
    }
}
