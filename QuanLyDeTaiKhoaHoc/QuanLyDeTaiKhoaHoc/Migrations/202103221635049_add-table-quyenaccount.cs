namespace QuanLyDeTaiKhoaHoc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablequyenaccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuyenAccounts",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        MaQuyen = c.String(),
                        TenQuyen = c.String(),
                        GhiChu = c.String(),
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
            DropTable("dbo.QuyenAccounts");
        }
    }
}
