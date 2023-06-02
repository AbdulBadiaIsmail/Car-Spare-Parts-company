namespace Car_Spare_Parts_company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        BillAmount = c.Int(nullable: false),
                        Type = c.String(),
                        Date = c.DateTime(nullable: false),
                        Client_ID = c.Int(),
                        Supplier_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.Client_ID)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID)
                .Index(t => t.Client_ID)
                .Index(t => t.Supplier_ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Salary = c.Double(nullable: false),
                        Phone = c.Int(nullable: false),
                        Adderss = c.String(),
                        Hrs_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HRs", t => t.Hrs_ID)
                .Index(t => t.Hrs_ID);
            
            CreateTable(
                "dbo.HRs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Salary = c.Double(nullable: false),
                        Phone = c.Int(nullable: false),
                        Adderss = c.String(),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Products",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                    Amount = c.Int(nullable: false),
                    BuyingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Employee_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID);
                
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Refunds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ClientName = c.String(nullable: false),
                        Productname = c.String(nullable: false),
                        dataofrefund = c.DateTime(name: "data of refund", nullable: false),
                        ProductPrice = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.EmployeeClients",
                c => new
                    {
                        Employee_ID = c.Int(nullable: false),
                        Client_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_ID, t.Client_ID })
                .ForeignKey("dbo.Employees", t => t.Employee_ID, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ID, cascadeDelete: true)
                .Index(t => t.Employee_ID)
                .Index(t => t.Client_ID);
            
            CreateTable(
                "dbo.ProductBills",
                c => new
                    {
                        Product_ID = c.Int(nullable: false),
                        Bill_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ID, t.Bill_ID })
                .ForeignKey("dbo.Products", t => t.Product_ID, cascadeDelete: true)
                .ForeignKey("dbo.Bills", t => t.Bill_ID, cascadeDelete: true)
                .Index(t => t.Product_ID)
                .Index(t => t.Bill_ID);
            
            CreateTable(
                "dbo.SupplierEmployees",
                c => new
                    {
                        Supplier_ID = c.Int(nullable: false),
                        Employee_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Supplier_ID, t.Employee_ID })
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_ID, cascadeDelete: true)
                .Index(t => t.Supplier_ID)
                .Index(t => t.Employee_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierEmployees", "Employee_ID", "dbo.Employees");
            DropForeignKey("dbo.SupplierEmployees", "Supplier_ID", "dbo.Suppliers");
            DropForeignKey("dbo.Bills", "Supplier_ID", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "Employee_ID", "dbo.Employees");
            DropForeignKey("dbo.ProductBills", "Bill_ID", "dbo.Bills");
            DropForeignKey("dbo.ProductBills", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.Employees", "Hrs_ID", "dbo.HRs");
            DropForeignKey("dbo.EmployeeClients", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.EmployeeClients", "Employee_ID", "dbo.Employees");
            DropForeignKey("dbo.Bills", "Client_ID", "dbo.Clients");
            DropIndex("dbo.SupplierEmployees", new[] { "Employee_ID" });
            DropIndex("dbo.SupplierEmployees", new[] { "Supplier_ID" });
            DropIndex("dbo.ProductBills", new[] { "Bill_ID" });
            DropIndex("dbo.ProductBills", new[] { "Product_ID" });
            DropIndex("dbo.EmployeeClients", new[] { "Client_ID" });
            DropIndex("dbo.EmployeeClients", new[] { "Employee_ID" });
            DropIndex("dbo.Products", new[] { "Employee_ID" });
            DropIndex("dbo.Employees", new[] { "Hrs_ID" });
            DropIndex("dbo.Bills", new[] { "Supplier_ID" });
            DropIndex("dbo.Bills", new[] { "Client_ID" });
            DropTable("dbo.SupplierEmployees");
            DropTable("dbo.ProductBills");
            DropTable("dbo.EmployeeClients");
            DropTable("dbo.Refunds");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.HRs");
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
            DropTable("dbo.Bills");
        }
    }
}
