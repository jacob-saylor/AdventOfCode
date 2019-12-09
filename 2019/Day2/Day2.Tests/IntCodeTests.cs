using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2.Tests
{
    [TestClass]
    public class IntCodeTests
    {
        [TestMethod]
        public void IntroTest()
        {
            // 1,9,10,3,2,3,11,0,99,30,40,50

            // 3500,9,10,70,2,3,11,0,99,30,40,50
        }

        [TestMethod]
        public void Test1()
        {
            //1,0,0,0,99 becomes 2,0,0,0,99 (1 + 1 = 2).
        }

        [TestMethod]
        public void Test2()
        {
            //2,3,0,3,99 becomes 2,3,0,6,99 (3 * 2 = 6).

        }

        [TestMethod]
        public void Test3()
        {
            //2,4,4,5,99,0 becomes 2,4,4,5,99,9801 (99 * 99 = 9801).

        }

        [TestMethod]
        public void Test4()
        {
            //1,1,1,4,99,5,6,0,99 becomes 30,1,1,4,2,5,6,0,99.
        }
    }
}
