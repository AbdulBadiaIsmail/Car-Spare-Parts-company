namespace Car_Spare_Parts_company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        Password = c.String(),
                        type = c.String(maxLength: 20),
                        employeeid = c.Int(),
                        HRSid = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.employeeid)
                .ForeignKey("dbo.HRs", t => t.HRSid)
                .Index(t => t.employeeid)
                .Index(t => t.HRSid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "HRSid", "dbo.HRs");
            DropForeignKey("dbo.Users", "employeeid", "dbo.Employees");
            DropIndex("dbo.Users", new[] { "HRSid" });
            DropIndex("dbo.Users", new[] { "employeeid" });
            DropTable("dbo.Users");
        }
    }
}
