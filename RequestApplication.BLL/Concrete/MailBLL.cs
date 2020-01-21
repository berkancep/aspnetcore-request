using RequestApplication.BLL.Abstract;
using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace RequestApplication.BLL.Concrete
{
    public class MailBLL : IMailBLL
    {
        private readonly IUserBLL _userBLL;

        public MailBLL(IUserBLL userBLL)
        {
            _userBLL = userBLL;
        }

        public bool SendMail(Request request)
        {
            var user = _userBLL.GetUserById((int)request.UserId);

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("kartalcep@gmail.com", "Berkan Çep");

                    mail.To.Add(user.Email);

                    mail.Subject = "Talep Yanıtı";
                    mail.IsBodyHtml = true;
                    mail.Body = $"<p>Talebiniz yanıtlandı.</p> <p>Sonuç : {request.IsPositive}</p> <p>{request.Reply}</p>";

                    using (SmtpClient sc = new SmtpClient("smtp.gmail.com", 587))
                    {
                        sc.Credentials = new NetworkCredential("kartalcep@gmail.com", "1903199708");
                        sc.EnableSsl = true;

                        sc.Send(mail);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
