using QuanLyDeTaiKhoaHoc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeTaiKhoaHoc.DTO
{
    public class QuyenAccountViewModel
    {
        public QuyenAccountViewModel()
        {

        }

        public QuyenAccountViewModel(QuyenAccount dataQuyenAccount)
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
