namespace BankWithUs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountsAndReceipt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        AccountNum = c.Int(nullable: false),
                        DebitNum = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        AccountPin = c.Int(nullable: false),
                        PhoneNum = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        CheckingAmount = c.Double(nullable: false),
                        SavingsAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        ReceiptId = c.Int(nullable: false, identity: true),
                        AccountNumber = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 15),
                        LastName = c.String(nullable: false, maxLength: 15),
                        Amount = c.Double(nullable: false),
                        NewCheckingBalance = c.Double(nullable: false),
                        NewSavingsBalance = c.Double(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReceiptId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Receipts");
            DropTable("dbo.Accounts");
        }
    }
}
