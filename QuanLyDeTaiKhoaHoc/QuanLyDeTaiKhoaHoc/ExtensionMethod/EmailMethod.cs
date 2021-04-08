using QuanLyDeTaiKhoaHoc.Model;
using System.Net;
using System.Net.Mail;

namespace QuanLyDeTaiKhoaHoc
{
    public static class EmailMethod
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static void SendMail(string x_strSubject, string x_strContent, MailInfo x_objMailInfoFrom, MailInfo x_objMailInfoTo)
        {
            var fromAddress = new MailAddress(x_objMailInfoFrom.Email, x_objMailInfoFrom.Name);
            var toAddress = new MailAddress(x_objMailInfoTo.Email, x_objMailInfoTo.Name);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, x_objMailInfoFrom.Pass)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = x_strSubject,
                Body = x_strContent
            })
            {
                smtp.Send(message);
            }
        }
    }
}
