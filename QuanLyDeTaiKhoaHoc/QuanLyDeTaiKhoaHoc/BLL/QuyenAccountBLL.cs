using QuanLyDeTaiKhoaHoc.DAL;
using QuanLyDeTaiKhoaHoc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeTaiKhoaHoc.BLL
{
    public class QuyenAccountBLL
    {
        public List<QuyenAccountViewModel> GetListViewModel()
        {
            using (var context = new QuanLyDeTaiKhoaHocContext())
            {
                List<QuyenAccountViewModel> quyenAccountViewModels = new List<QuyenAccountViewModel>();
                var dataQuyenAccounts = context.QuyenAccounts.Where(x => x.Deleted == false).ToList();

                foreach(var dataQuyenAccount in dataQuyenAccounts)
                {
                    quyenAccountViewModels.Add(new QuyenAccountViewModel(dataQuyenAccount));
                }    

                return quyenAccountViewModels;
            }
        }
    }
}
