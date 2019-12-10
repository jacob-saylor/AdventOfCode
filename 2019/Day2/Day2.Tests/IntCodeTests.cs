using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2.Tests
{
    [TestClass]
    public class IntCodeTests
    {
        [TestMethod]
        public void IntroTest()
        {
            var programs = "1,9,10,3,2,3,11,0,99,30,40,50";
            var result = IntcodeProgram.ProcessProgramString(programs);
            Assert.AreEqual("3500,9,10,70,2,3,11,0,99,30,40,50", result);            
        }

        [TestMethod]
        public void Test1()
        {
            var programs = "1,0,0,0,99";
            var result = IntcodeProgram.ProcessProgramString(programs);
            Assert.AreEqual("2,0,0,0,99", result);                       
        }

        [TestMethod]
        public void Test2()
        {
            var programs = "2,3,0,3,99";
            var result = IntcodeProgram.ProcessProgramString(programs);
            Assert.AreEqual("2,3,0,6,99", result);
        }

        [TestMethod]
        public void Test3()
        {
            var programs = "2,4,4,5,99,0";
            var result = IntcodeProgram.ProcessProgramString(programs);
            Assert.AreEqual("2,4,4,5,99,9801", result);
        }

        [TestMethod]
        public void Test4()
        {
            var programs = "1,1,1,4,99,5,6,0,99";
            var result = IntcodeProgram.ProcessProgramString(programs);
            Assert.AreEqual("30,1,1,4,2,5,6,0,99", result);
        }
    }
}
