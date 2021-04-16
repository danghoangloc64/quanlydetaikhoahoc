using EASendMail;
using QuanLyDeTaiKhoaHoc.Model;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using SmtpClient = EASendMail.SmtpClient;

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

        public static string RandomPassword()
        {
            return CommonLibrary.RandomString(10);
        }

        //public static void SendMail(string x_strSubject, string x_strContent, MailInfo x_objMailInfoFrom, MailInfo x_objMailInfoTo)
        //{
        //    //var fromAddress = new MailAddress(x_objMailInfoFrom.Email, x_objMailInfoFrom.Name);
        //    //var toAddress = new MailAddress(x_objMailInfoTo.Email, x_objMailInfoTo.Name);

        //    //var smtp = new SmtpClient
        //    //{
        //    //    Host = "smtp.gmail.com",
        //    //    Port = 587,
        //    //    EnableSsl = true,
        //    //    DeliveryMethod = SmtpDeliveryMethod.Network,
        //    //    UseDefaultCredentials = false,
        //    //    Credentials = new NetworkCredential(fromAddress.Address, x_objMailInfoFrom.Pass)
        //    //};
        //    //using (var message = new MailMessage(fromAddress, toAddress)
        //    //{
        //    //    Subject = x_strSubject,
        //    //    Body = x_strContent
        //    //})
        //    //{
        //    //    smtp.Send(message);
        //    //}
        //}

        public static void SendMail(string x_strSubject, string x_strContent, MailInfo x_objMailInfoFrom, MailInfo x_objMailInfoTo)
        {
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");

                // Your gmail email address
                oMail.From = x_objMailInfoFrom.Email;
                // Set recipient email address
                oMail.To = x_objMailInfoTo.Email;

                // Set email subject
                oMail.Subject = x_strSubject;
                // Set email body
                oMail.TextBody = x_strContent;

                // Gmail SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                // Gmail user authentication
                // For example: your email is "gmailid@gmail.com", then the user should be the same
                oServer.User = x_objMailInfoFrom.Email;
                oServer.Password = x_objMailInfoFrom.Pass;

                // Set 465 port
                oServer.Port = 465;

                // detect SSL/TLS automatically
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                Debug.WriteLine("start to send email over SSL ...");

                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);

                Debug.WriteLine("email was sent successfully!");
            }
            catch (Exception ep)
            {
                Debug.WriteLine("failed to send email with the following error:");
                Debug.WriteLine(ep.Message);
            }
        }
    }
}