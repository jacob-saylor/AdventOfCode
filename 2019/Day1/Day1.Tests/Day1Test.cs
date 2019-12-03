using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Day1.Tests
{
    [TestClass]
    public class Day1Test
    {
        [TestMethod]
        public void TestMass_12()
        {
            var mass = 12;
            
            var fuelRequired = Day1.FuelCalculator.DetermineFuelRequired(mass);
            Assert.AreEqual(2, fuelRequired);
        }

        [TestMethod]
        public void TestMass_14()
        {
            var mass = 14;

            var fuelRequired = Day1.FuelCalculator.DetermineFuelRequired(mass);
            Assert.AreEqual(2, fuelRequired);
        }

        [TestMethod]
        public void TestMass_1969()
        {
            var mass = 1969;

            var fuelRequired = Day1.FuelCalculator.DetermineFuelRequired(mass);
            Assert.AreEqual(654, fuelRequired);
        }

        [TestMethod]
        public void TestMass_100756()
        {
            var mass = 100756;

            var fuelRequired = Day1.FuelCalculator.DetermineFuelRequired(mass);
            Assert.AreEqual(33583, fuelRequired);
        }
    }
}
