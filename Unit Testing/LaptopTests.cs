using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace Unit_Testing
{
    [TestClass]
    public class LaptopTests
    {
        
        Laptop test_laptop = new Laptop("laptop", "samsung", "linux");

        [TestMethod]
        public void ConstructorSetsBatteryLevel()
        {
            Assert.AreEqual(100, test_laptop.BatteryLevel);
        }
        [TestMethod]
        public void TestBatteryChange()
        {
            test_laptop.CheckBatteryLevel();
            Assert.AreEqual(95, test_laptop.BatteryLevel);
        }
        [TestMethod]
        public void CheckIP()
        {
            Assert.AreEqual("10.000.000.1", test_laptop.IP);
        }
        [TestMethod]
        public void CheckSendEmail()
        {
            string str = test_laptop.SendEmail("Joe", "Wazzzzzup");
            Assert.AreEqual("Email sent to Joe, the message was Wazzzzzup", str);
        }
            
    }
}
