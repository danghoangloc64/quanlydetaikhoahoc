using QuanLyDeTaiKhoaHoc.Model;
using System.ComponentModel;

namespace QuanLyDeTaiKhoaHoc.DTO
{
    public class QuyenViewModel
    {
        public QuyenViewModel()
        {

        }

        public QuyenViewModel(Quyen dataQuyenAccount)
        {
            MaQuyen = dataQuyenAccount.MaQuyen;
            TenQuyen = dataQuyenAccount.TenQuyen;
            GhiChu = dataQuyenAccount.GhiChu;
        }

        [DisplayName("Mã quyền")]
        public string MaQuyen { get; set; }

        [DisplayName("Tên quyền")]
        public string TenQuyen { get; set; }

        [DisplayName("Ghi chú")]
        public string GhiChu { get; set; }
    }
}
