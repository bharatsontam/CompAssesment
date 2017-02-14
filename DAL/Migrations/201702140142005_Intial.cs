namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Moniker = c.String(nullable: false, maxLength: 4),
                        HeadOfDepartment_Id = c.Guid(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructors", t => t.HeadOfDepartment_Id, cascadeDelete: true)
                .Index(t => t.HeadOfDepartment_Id);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Department_Id = c.Guid(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Advisor_Id = c.Guid(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructors", t => t.Advisor_Id)
                .Index(t => t.Advisor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "HeadOfDepartment_Id", "dbo.Instructors");
            DropForeignKey("dbo.Instructors", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Students", "Advisor_Id", "dbo.Instructors");
            DropIndex("dbo.Departments", new[] { "HeadOfDepartment_Id" });
            DropIndex("dbo.Instructors", new[] { "Department_Id" });
            DropIndex("dbo.Students", new[] { "Advisor_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Instructors");
            DropTable("dbo.Departments");
        }
    }
}
