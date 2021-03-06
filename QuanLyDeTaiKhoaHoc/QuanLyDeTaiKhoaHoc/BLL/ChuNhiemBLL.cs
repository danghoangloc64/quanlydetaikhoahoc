using QuanLyDeTaiKhoaHoc.DAL;
using QuanLyDeTaiKhoaHoc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeTaiKhoaHoc.BLL
{
  public  class ChuNhiemBLL
    {
        public List<ChuNhiemViewModel> GetListViewModel()
        {
            using (var context = new QuanLyDeTaiKhoaHocContext())
            {
                List<ChuNhiemViewModel> chuNhiemViewModels = new List<ChuNhiemViewModel>();
                var dataChuNhiems = context.ChuNhiems.Where(x => x.Deleted == false).ToList();

                foreach (var dataChuNhiem in dataChuNhiems)
                {
                    chuNhiemViewModels.Add(new  ChuNhiemViewModel(dataChuNhiem));
                }

                return chuNhiemViewModels;
            }
        }
    }
}
