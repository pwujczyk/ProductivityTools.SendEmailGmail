using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductivityTools.SendEmailGmail;

namespace ProductivityTools.SendEmailGmailTests
{
    [TestClass]
    public class GmailTests
    {
        [TestMethod]
        public void SendEmail()
        {
            Gmail.Send("", "", "", "pawel", "fsda");
        }
    }
}
