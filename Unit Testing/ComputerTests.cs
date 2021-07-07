using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace Unit_Testing
{
    [TestClass]
    public class ComputerTests
    { 
        Computer test_computer = new Computer("computer", "dell", "windows");

        [TestMethod]
        public void ConstructorSetsName()
        {
            Assert.AreEqual("computer", test_computer.Name);
        }
        [TestMethod]
        public void SendEmailSendsEmail()
        {
            string str = test_computer.SendEmail("Joe", "Wazzzzzup");
            Assert.AreEqual("Email sent to Joe, the message was Wazzzzzup", str);
        }
        [TestMethod]
        public void CheckIP()
        {
            Assert.AreEqual("10.000.000.1", test_computer.IP);
        }
    }
}
