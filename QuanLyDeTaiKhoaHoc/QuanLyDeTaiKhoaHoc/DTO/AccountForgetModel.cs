using System.ComponentModel;

namespace QuanLyDeTaiKhoaHoc.DTO
{
    public class AccountForgetModel
    {
        [DisplayName("Tên đăng nhập")]
        public string TenDangNhap { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
