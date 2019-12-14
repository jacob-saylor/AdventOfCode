using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day3.Tests
{
    [TestClass]
    public class Day3Test
    {
        [TestMethod]
        public void Sample1()
        {
            var firstWire = "R75,D30,R83,U83,L12,D49,R71,U7,L72";
            var secondWire = "U62,R66,U55,R34,D71,R55,D58,R83";

            var result = WireCalculation.DetermineManhattanDistance(firstWire, secondWire);

            Assert.AreEqual(159, result);
        }

        [TestMethod]
        public void Sample2()
        {
            var firstWire = "R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51";
            var secondWire = "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7";

            var result = WireCalculation.DetermineManhattanDistance(firstWire, secondWire);

            Assert.AreEqual(135, result);
        }
    }
}
