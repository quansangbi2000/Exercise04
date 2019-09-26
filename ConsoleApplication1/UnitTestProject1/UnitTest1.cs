using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result03 = Program.IsOdd(3);
            Assert.AreEqual(false, result03);

            bool result04 = Program.IsOdd(4);
            Assert.AreEqual(false, result04);
        }
    }
}
