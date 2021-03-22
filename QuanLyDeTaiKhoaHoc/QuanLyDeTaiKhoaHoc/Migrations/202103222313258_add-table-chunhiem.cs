namespace QuanLyDeTaiKhoaHoc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablechunhiem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChuNhiems",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        MaChuNhiem = c.String(),
                        TenChuNhiem = c.String(),
                        NgaySinh = c.DateTime(),
                        GioiTinh = c.String(),
                        SoDienThoai = c.String(),
                        Email = c.String(),
                        QueQuan = c.String(),
                        ChuyenNganh = c.String(),
                        HocHamHocVi = c.String(),
                        DonViCongTac = c.String(),
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
            DropTable("dbo.ChuNhiems");
        }
    }
}
