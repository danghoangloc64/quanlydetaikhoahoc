using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeTaiKhoaHoc.Model
{
    public class ChuNhiem : AuditableEntity<Guid>
    {
        public string MaChuNhiem { get; set; }
        public string TenChuNhiem { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string QueQuan { get; set; }
        public string ChuyenNganh { get; set; }
        public string HocHamHocVi { get; set; }
        public string DonViCongTac { get; set; }
    }
}
