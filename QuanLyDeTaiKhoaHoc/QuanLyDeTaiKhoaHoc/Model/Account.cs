using System;
using System.Collections.Generic;

namespace QuanLyDeTaiKhoaHoc.Model
{
    public class Account : AuditableEntity<Guid>
    {
        public string TenDangNhap { get; set; }
        public string TenDayDu { get; set; }
        public string Email { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string MatKhau { get; set; }

        public virtual ICollection<Quyen> QuyenAccounts { get; set; }
    }
}
