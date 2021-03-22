namespace QuanLyDeTaiKhoaHoc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtableaccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        TenDangNhap = c.String(),
                        TenDayDu = c.String(),
                        Email = c.String(),
                        NgaySinh = c.DateTime(),
                        MatKhau = c.String(),
                        Deleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
