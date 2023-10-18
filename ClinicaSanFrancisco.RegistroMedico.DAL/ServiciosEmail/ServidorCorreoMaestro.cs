using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
namespace ClinicaSanFrancisco.RegistroMedico.DAL.ServiciosEmail
{
    public abstract class ServidorCorreoMaestro
    {
        private SmtpClient smtpClient;
        protected string EnviarMail { get; set; }
        protected String contrasena { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient() {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(EnviarMail, contrasena);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void EnviarEmail(string subject, string body, List<string> recipientMail) {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(EnviarMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);

            }
            catch (Exception) { }
            

                finally {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
