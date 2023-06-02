namespace Car_Spare_Parts_company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updat_user : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "MobileNO", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            DropColumn("dbo.Users", "MobileNO");
        }
    }
}
