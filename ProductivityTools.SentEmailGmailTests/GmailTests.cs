using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductivityTools.SentEmailGmail;

namespace ProductivityTools.SentEmailGmailTests
{
    [TestClass]
    public class GmailTests
    {
        [TestMethod]
        public void SentEmail()
        {
            Gmail.Send("", "", "", "pawel", "fsda");
        }
    }
}
