using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day3.Tests
{
    [TestClass]
    public class Day3Test
    {
        [TestMethod]
        public void DetermineManhattanDistance__Intro()
        {
            var firstWire = "R8,U5,L5,D3";
            var secondWire = "U7,R6,D4,L4";

            var result = WireCalculation.DetermineManhattanDistance(firstWire, secondWire);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void DetermineManhattanDistance_1()
        {
            var firstWire = "R75,D30,R83,U83,L12,D49,R71,U7,L72";
            var secondWire = "U62,R66,U55,R34,D71,R55,D58,R83";

            var result = WireCalculation.DetermineManhattanDistance(firstWire, secondWire);

            Assert.AreEqual(159, result);
        }

        [TestMethod]
        public void DetermineManhattanDistance_2()
        {
            var firstWire = "R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51";
            var secondWire = "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7";

            var result = WireCalculation.DetermineManhattanDistance(firstWire, secondWire);

            Assert.AreEqual(135, result);
        }          
        
        [TestMethod]
        public void DetermineShortestLength_Intro()
        {
            var firstWire = "R8,U5,L5,D3";
            var secondWire = "U7,R6,D4,L4";

            var result = WireCalculation.DetermineShortestLength(firstWire, secondWire);

            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void DetermineShortestLength_1()
        {
            var firstWire = "R75,D30,R83,U83,L12,D49,R71,U7,L72";
            var secondWire = "U62,R66,U55,R34,D71,R55,D58,R83";

            var result = WireCalculation.DetermineShortestLength(firstWire, secondWire);

            Assert.AreEqual(610, result);
        }

        [TestMethod]
        public void DetermineShortestLength_2()
        {
            var firstWire = "R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51";
            var secondWire = "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7";

            var result = WireCalculation.DetermineShortestLength(firstWire, secondWire);

            Assert.AreEqual(410, result);
        }
    }
}
