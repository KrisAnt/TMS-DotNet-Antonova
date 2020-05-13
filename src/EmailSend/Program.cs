using System;
using System.Net;
using System.Net.Mail;
using EmailSendLib;

namespace EmailSend
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailSending email = new EmailSending();
            email.EmailSend("smtp.mail.ru", "kristy_92@inbox.ru", "krienglish92", "kristyemail@mailinator.com", "MySubject", "Hello, it's a test mail");
        }
    }
}
