namespace assignment_pc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areatbls",
                c => new
                    {
                        AreaId = c.Long(nullable: false, identity: true),
                        AreaName = c.String(),
                        CityId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.AreaId)
                .ForeignKey("dbo.citytbls", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.citytbls",
                c => new
                    {
                        CityId = c.Long(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.bills",
                c => new
                    {
                        BillId = c.Long(nullable: false, identity: true),
                        BillDate = c.DateTime(nullable: false),
                        BillNo = c.Long(nullable: false),
                        CustomerId = c.Long(nullable: false),
                        BillAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BillId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Long(nullable: false, identity: true),
                        CustomerName = c.String(),
                        AreaId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Areatbls", t => t.AreaId, cascadeDelete: true)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Long(nullable: false, identity: true),
                        PaymentDate = c.DateTime(nullable: false),
                        PaymentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BillId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.bills", t => t.BillId, cascadeDelete: true)
                .Index(t => t.BillId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "BillId", "dbo.bills");
            DropForeignKey("dbo.bills", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "AreaId", "dbo.Areatbls");
            DropForeignKey("dbo.Areatbls", "CityId", "dbo.citytbls");
            DropIndex("dbo.Payments", new[] { "BillId" });
            DropIndex("dbo.Customers", new[] { "AreaId" });
            DropIndex("dbo.bills", new[] { "CustomerId" });
            DropIndex("dbo.Areatbls", new[] { "CityId" });
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
            DropTable("dbo.bills");
            DropTable("dbo.citytbls");
            DropTable("dbo.Areatbls");
        }
    }
}
