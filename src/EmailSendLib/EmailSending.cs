using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EmailSendLib
{
    /// <summary>
    /// Отправка сообщений по почте
    /// </summary>
    public class EmailSending
    {
        /// <summary>
        /// Отправка сообщения
        /// </summary>
        /// <param name="smtpHost">Хост</param>
        /// <param name="from">Адрес отправителя</param>
        /// <param name="password">Пароль для аутентификации</param>
        /// <param name="to">Адрес получателя</param>
        /// <param name="subject">Тема письма</param>
        /// <param name="message">Письмо</param>

        public void EmailSend(string smtpHost, string from, string password, string to, string subject, string message)
        {
            MailMessage mail = MessageSend(from, to, subject, message);
            SendEmailBySmtpClient(smtpHost, mail);
        }

        /// <summary>
        /// Взаимодействие с smtp-клиентом
        /// </summary>
        /// <param name="smtpHost">Хост</param>
        /// <param name="mail">Письмо</param>

        public void SendEmailBySmtpClient(string smtpHost, MailMessage mail)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Host = smtpHost;
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(mail.From.Address, "krienglish92");
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Создает объект MailMessage 
        /// </summary>
        /// <param name="from">Адрес отправителя</param>
        /// <param name="to">Адрес получаетеля</param>
        /// <param name="subject">Тема письма</param>
        /// <param name="message">Письмо</param>
        /// <returns></returns>
        public MailMessage MessageSend(string from, string to, string subject, string message)
        {
            if (string.IsNullOrEmpty(from))
                throw new ArgumentException("You must specify an email address. From is null");

            if (!EmailIsValid(from))
                throw new ArgumentException("This email in not valid");

            if (string.IsNullOrEmpty(to))
                throw new ArgumentException("You must specify an email address",
                    nameof(to));

            if (!EmailIsValid(to))
                throw new ArgumentException("This email in not valid");

            if (string.IsNullOrEmpty(subject))
                throw new ArgumentException("You must specify an email subject",
                    nameof(subject));

            if (string.IsNullOrEmpty(message))
                throw new ArgumentException("You must specify a email body ",
                    nameof(message));

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            mail.Subject = subject;
            mail.Body = message;
            return mail;
        }
        public bool EmailIsValid(string mail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(mail))
                return (true);
            else
                return (false);
        }
    }
}
