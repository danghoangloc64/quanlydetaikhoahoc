using System;

namespace QuanLyDeTaiKhoaHoc.Model
{
    public class Account : AuditableEntity<Guid>
    {
        public string TenDangNhap { get; set; }
        public string TenDayDu { get; set; }
        public string Email { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string MatKhau { get; set; }

        public Guid QuyenAccountId { get; set; }
        public virtual QuyenAccount QuyenAccount { get; set; }
    }
}
