using System.ComponentModel;

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
