using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.EmailServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
     public class SmtpEmailSender: IEmailSender
    {
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials = new NetworkCredential(_userName,_password),
                EnableSsl=this._enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(this._userName,email,subject,htmlMessage)
                {
                    IsBodyHtml=true
                });
        }
    }
   
    
}
