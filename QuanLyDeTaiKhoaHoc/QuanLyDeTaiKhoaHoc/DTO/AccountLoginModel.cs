using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeTaiKhoaHoc.DTO
{
    public class AccountLoginModel
    {
        [DisplayName("Tên đăng nhập")]
        public string TenDangNhap { get; set; }

        [DisplayName("Mật khẩu")]
        public string MatKhau { get; set; }

        [DisplayName("Quyền")]
        public string Quyen { get; set; }
    }
}
