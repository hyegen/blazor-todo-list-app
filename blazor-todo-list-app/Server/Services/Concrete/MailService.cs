using System.Net.Mail;
using System.Net;
using blazor_todo_list_app.Server.Services.Interfaces;

namespace blazor_todo_list_app.Server.Services.Concrete
{
    public class MailService : IMailService
    {
        #region members
        private readonly SmtpClient _smtpClient;
        private readonly string _fromEmail;
        #endregion

        #region constructor
        public MailService(IConfiguration configuration)
        {
            var smtpServer = configuration["SmtpSettings:Server"];
            var smtpPort = int.Parse(configuration["SmtpSettings:Port"]);
            var smtpPassword = configuration["SmtpSettings:Password"];
            _fromEmail = configuration["SmtpSettings:FromEmail"];

            _smtpClient = new SmtpClient(smtpServer, smtpPort)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_fromEmail, smtpPassword),
                EnableSsl = true
            };
        }
        #endregion

        #region methods
        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_fromEmail),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(toEmail);
                await _smtpClient.SendMailAsync(mailMessage);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
