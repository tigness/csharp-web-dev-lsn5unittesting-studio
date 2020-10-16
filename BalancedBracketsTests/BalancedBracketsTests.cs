using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[launch]code["));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[launch]]]"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[La[u[[n]ch]Co]]de"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[L]]a["));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]Launch[Code"));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]Launch[]Code[]"));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[Launch][Code]]"));
        }

        [TestMethod]
        public void Test12()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[Launch]]Code[]"));
        }
    }
}
