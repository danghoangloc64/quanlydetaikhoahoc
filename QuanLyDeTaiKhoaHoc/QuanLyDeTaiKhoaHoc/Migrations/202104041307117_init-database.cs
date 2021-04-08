namespace QuanLyDeTaiKhoaHoc.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initdatabase : DbMigration
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
            
            CreateTable(
                "dbo.Quyens",
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
            
            CreateTable(
                "dbo.QuyenAccounts",
                c => new
                    {
                        Quyen_Id = c.Guid(nullable: false),
                        Account_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Quyen_Id, t.Account_Id })
                .ForeignKey("dbo.Quyens", t => t.Quyen_Id, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.Account_Id, cascadeDelete: true)
                .Index(t => t.Quyen_Id)
                .Index(t => t.Account_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuyenAccounts", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.QuyenAccounts", "Quyen_Id", "dbo.Quyens");
            DropIndex("dbo.QuyenAccounts", new[] { "Account_Id" });
            DropIndex("dbo.QuyenAccounts", new[] { "Quyen_Id" });
            DropTable("dbo.QuyenAccounts");
            DropTable("dbo.ChuNhiems");
            DropTable("dbo.Quyens");
            DropTable("dbo.Accounts");
        }
    }
}
