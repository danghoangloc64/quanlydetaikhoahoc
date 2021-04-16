using QuanLyDeTaiKhoaHoc.DAL;
using QuanLyDeTaiKhoaHoc.DTO;
using QuanLyDeTaiKhoaHoc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeTaiKhoaHoc.BLL
{
    public class QuyenBLL
    {
        public List<QuyenViewModel> GetListViewModel()
        {
            using (var context = new QuanLyDeTaiKhoaHocContext())
            {
                List<QuyenViewModel> quyenAccountViewModels = new List<QuyenViewModel>();
                var dataQuyenAccounts = context.Quyens.Where(x => x.Deleted == false);
                foreach (var dataQuyenAccount in dataQuyenAccounts)
                {
                    quyenAccountViewModels.Add(new QuyenViewModel(dataQuyenAccount));
                }
                return quyenAccountViewModels;
            }
        }
        public string[] GetListViewModelByUserName(string x_strUserName)
        {
            using (var context = new QuanLyDeTaiKhoaHocContext())
            {
                List<string> listTenQuyen = new List<string>();

                var dataQuyenAccounts = context.Quyens.Where(x => x.Deleted == false && x.Accounts.Any(y => y.Deleted == false && y.TenDangNhap == x_strUserName)).ToList();
                foreach (var dataQuyenAccount in dataQuyenAccounts)
                {
                    listTenQuyen.Add(dataQuyenAccount.MaQuyen);
                }

                return listTenQuyen.ToArray();
            }
        }
    }
}
