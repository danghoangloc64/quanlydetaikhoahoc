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
                Quyen quyenAccount = context.Quyens.FirstOrDefault(x => x.Deleted == false && x.MaQuyen == objAccountLoginModel.Quyen);
                if (quyenAccount == null)
                {
                    return false;
                }
                else
                {
                    objAccountLoginModel.MatKhau = CommonLibrary.CreateMD5(objAccountLoginModel.MatKhau);
                    Account account = context.Accounts.FirstOrDefault(x => x.Deleted == false && x.TenDangNhap == objAccountLoginModel.TenDangNhap
                                                                            && x.MatKhau.ToLower() == objAccountLoginModel.MatKhau.ToLower()
                                                                            && x.QuyenAccounts.Any(y => y.Deleted == false && y.Id == quyenAccount.Id));
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

        public bool ForgetPassword(AccountForgetModel m_objAccountForgetModel)
        {
            using (var context = new QuanLyDeTaiKhoaHocContext())
            {
                var data = context.Accounts.FirstOrDefault(x => x.Deleted == false && x.Email == m_objAccountForgetModel.Email && x.TenDangNhap == m_objAccountForgetModel.TenDangNhap);
                if (data == null)
                {
                    return false;
                }
                else
                {
                    MailInfo mailInfoFrom = new MailInfo()
                    {
                        Email = Constants.MAIL_EMAIL_DEFAULT,
                        Name = Constants.MAIL_NAME_DEFAULT,
                        Pass = Constants.MAIL_PASSWORD_DEFAULT
                    };

                    MailInfo mailInfoTo = new MailInfo()
                    {
                        Email = data.Email
                    };

                    string strNewPassword = EmailMethod.RandomPassword();
                    string strMD5NewPassword = CommonLibrary.CreateMD5(strNewPassword);
                    data.MatKhau = strMD5NewPassword;
                    context.SaveChanges();

                    string content = $"Quản Lý Đề Tài Khoa Học cấp lại mật khẩu.\r\n\r\nTên đăng nhập: {data.TenDangNhap}\r\nMật khẩu: {strNewPassword}";

                    EmailMethod.SendMail("Cấp lại mật khẩu - Quản Lý Đề Tài Khoa Học", content, mailInfoFrom, mailInfoTo);
                    return true;
                }
            }
        }
    }
}
