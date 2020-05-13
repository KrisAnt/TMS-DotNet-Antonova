using System;
using System.Linq;
using System.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailSendLib.Tests
{
    [TestClass]
    public class EmailSendingTests
    {
        [TestMethod]
        public void MessageSend_()
        {
            // Arrange
            string from = "kristy_92@inbox.ru";
            string to = "kristyemail@mailinator.com";
            string subject = "MySubject";
            string message = "Hello, it's a test mail";
            // Act
            EmailSending email = new EmailSending();
            MailMessage actual = email.MessageSend(from, to, subject, message);
            // Assert
            Assert.AreEqual(from, actual.From.Address);
            Assert.AreEqual(to, actual.To.First().Address);
            Assert.AreEqual(subject, actual.Subject);
            Assert.AreEqual(message, actual.Body);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(null, "kristyemail@mailinator.com", "MySubject", "Hello, it's a test mail")]
        [DataRow("kristy_92@inbox.ru", null, "MySubject", "Hello, it's a test mail")]
        [DataRow("kristy_92@inbox.ru", "kristyemail@mailinator.com", null, "Hello, it's a test mail")]
        [DataRow("kristy_92@inbox.ru", "kristyemail@mailinator.com", "MySubject", null)]

        public void MessageSend_StringIsNullOrEmpty_ExpectedException(string from, string to, string subject, string message)
        {
            // Act
            EmailSending email = new EmailSending();
            var actual = email.MessageSend(from, to, subject, message);
            // Assert
            Assert.ThrowsException<NullReferenceException>(() => email.MessageSend(from, to, subject, message));
        }
        [TestMethod]
        public void EmailIsValid_Returntrue()
        {
            // Arrange
            string mail = "kristy_92@inbox.ru";
            // Act
            EmailSending emailSending = new EmailSending();
            var actual = emailSending.EmailIsValid(mail);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void EmailIsValid_Returnfalse()
        {
            // Arrange
            string mail = "kristy_92inbox.ru";
            // Act
            EmailSending emailSending = new EmailSending();
            var actual = emailSending.EmailIsValid(mail);
            //Assert
            Assert.IsFalse(actual);
        }
    }
}
