namespace tasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.TeacherTransfers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        teacher_Id = c.Int(),
                        toSchool_Id = c.Int(),
                        fromSchool_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.teacher_Id)
                .ForeignKey("dbo.Schools", t => t.toSchool_Id)
                .ForeignKey("dbo.Schools", t => t.fromSchool_Id)
                .Index(t => t.teacher_Id)
                .Index(t => t.toSchool_Id)
                .Index(t => t.fromSchool_Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        schoolId = c.Int(nullable: false),
                        name = c.String(),
                        birthDate = c.DateTime(nullable: false),
                        NID = c.Int(nullable: false),
                        code = c.Int(nullable: false),
                        job = c.String(),
                        phone = c.Int(nullable: false),
                        qualification = c.String(),
                        qualificationDate = c.DateTime(nullable: false),
                        hiringDate = c.DateTime(nullable: false),
                        address = c.String(),
                        notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.schoolId, cascadeDelete: true)
                .Index(t => t.schoolId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schools", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.TeacherTransfers", "fromSchool_Id", "dbo.Schools");
            DropForeignKey("dbo.TeacherTransfers", "toSchool_Id", "dbo.Schools");
            DropForeignKey("dbo.TeacherTransfers", "teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "schoolId", "dbo.Schools");
            DropIndex("dbo.Teachers", new[] { "schoolId" });
            DropIndex("dbo.TeacherTransfers", new[] { "fromSchool_Id" });
            DropIndex("dbo.TeacherTransfers", new[] { "toSchool_Id" });
            DropIndex("dbo.TeacherTransfers", new[] { "teacher_Id" });
            DropIndex("dbo.Schools", new[] { "Department_Id" });
            DropTable("dbo.Teachers");
            DropTable("dbo.TeacherTransfers");
            DropTable("dbo.Schools");
            DropTable("dbo.Departments");
        }
    }
}
