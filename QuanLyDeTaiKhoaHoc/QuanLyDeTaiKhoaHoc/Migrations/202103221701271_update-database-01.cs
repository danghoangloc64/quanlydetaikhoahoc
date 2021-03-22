namespace QuanLyDeTaiKhoaHoc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "QuyenAccountId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Accounts", "QuyenAccountId");
            AddForeignKey("dbo.Accounts", "QuyenAccountId", "dbo.QuyenAccounts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "QuyenAccountId", "dbo.QuyenAccounts");
            DropIndex("dbo.Accounts", new[] { "QuyenAccountId" });
            DropColumn("dbo.Accounts", "QuyenAccountId");
        }
    }
}
