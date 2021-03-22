using QuanLyDeTaiKhoaHoc.DAL;
using QuanLyDeTaiKhoaHoc.DTO;
using QuanLyDeTaiKhoaHoc.Model;
using System;
using System.Linq;

namespace QuanLyDeTaiKhoaHoc.BLL
{
    public class AccountBLL
    {
        public bool Login(AccountLoginModel objAccountLoginModel)
        {
            using (var context = new QuanLyDeTaiKhoaHocContext())
            {
                QuyenAccount quyenAccount = context.QuyenAccounts.FirstOrDefault(x => x.Deleted == false && x.MaQuyen == objAccountLoginModel.Quyen);
                if (quyenAccount == null)
                {
                    return false;
                }
                else
                {
                    objAccountLoginModel.MatKhau = CommonLibrary.CreateMD5(objAccountLoginModel.MatKhau);
                    Account account = context.Accounts.FirstOrDefault(x => x.Deleted == false && x.TenDangNhap == objAccountLoginModel.TenDangNhap
                                                                            && x.MatKhau.Equals(objAccountLoginModel.MatKhau, StringComparison.OrdinalIgnoreCase)
                                                                            && x.QuyenAccount.Id == quyenAccount.Id);
                    if (account != null)
                    {
                        SystemConfiguration.SystemConfiguration.TenDayDu = account.TenDayDu;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
