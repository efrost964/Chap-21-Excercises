using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace Unit_Testing
{
    [TestClass]
    public class SmartPhoneTests
    {
        SmartPhone test_smartphone = new SmartPhone("smartphone", "apple", "iOS", "Verizon");
        Computer test_computer = new Computer("computer", "hp", "linux");

        [TestMethod]
        public void CheckMakeCall()
        {
            string str = test_smartphone.MakeCall(123);
            Assert.AreEqual("Calling 123.... Ring... Ring...", str);
        }
        [TestMethod]
        public void CheckBattery()
        {
            test_smartphone.CheckBatteryLevel();
            Assert.AreEqual(95, test_smartphone.BatteryLevel);
        }
        [TestMethod]
        public void CheckIPSmartPhone()
        {
            Assert.AreEqual("10.000.000.1", test_smartphone.IP);
        }
        [TestMethod]
        public void CheckIPComputer()
        {
            Assert.AreEqual("10.000.000.2", test_computer.IP);
        }
    }
}
