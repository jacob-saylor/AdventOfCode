using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day4.Tests
{
    [TestClass]
    public class PasswordValidatorTests
    {
        [TestMethod]
        public void MeetsDoubleCritera_AllSame_Valid()
        {
            var input = 111111;
            var result = PasswordValidator.MeetsDoubleCritera(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MeetsDoubleCritera_SingleDouble_Valid()
        {
            var input = 223450;
            var result = PasswordValidator.MeetsDoubleCritera(input);
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void MeetsDoubleCritera_SingleDouble_Middle_Valid()
        {
            var input = 347750;
            var result = PasswordValidator.MeetsDoubleCritera(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MeetsDoubleCritera_Invalid()
        {
            var input = 123789;
            var result = PasswordValidator.MeetsDoubleCritera(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MeetsNeverDecrease_Valid()
        {
            var input = 111111;
            var result = PasswordValidator.NeverDecrease(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MeetsNeverDecrease_Invalid()
        {
            var input = 765747;
            var result = PasswordValidator.NeverDecrease(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ContainsAtLeastOneDouble_Valid()
        {
            var input = 112233;
            var result = PasswordValidator.ContainsAtLeastOneDouble(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsAtLeastOneDouble_AtLeastOne_Valid()
        {
            var input = 111122;
            var result = PasswordValidator.ContainsAtLeastOneDouble(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsAtLeastOneDouble_Invalid()
        {
            var input = 123444;
            var result = PasswordValidator.ContainsAtLeastOneDouble(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ContainsAtLeastOneDouble_Middle_Invalid()
        {
            var input = 124443;
            var result = PasswordValidator.ContainsAtLeastOneDouble(input);
            Assert.IsFalse(result);
        }
    }
}
