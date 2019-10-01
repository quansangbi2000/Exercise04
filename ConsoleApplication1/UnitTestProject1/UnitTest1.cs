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
        public void TestIsEven()
        {
            bool result03 = Program.IsEven(3);
            Assert.AreEqual(true, result03);

            bool result04 = Program.IsEven(4);
            Assert.AreEqual(true, result04);
        }
        [TestMethod]
        public void TestCeil()
        {
            int result = Program.Ceil((float)2.3);
            Assert.AreEqual(3, result);

            int result2 = Program.Ceil(-2.3f);
            Assert.AreEqual(-2, result2);
        }

        [TestMethod]
        public void TestFloor()
        {
            int result1 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result1);

            int result2 = Program.Floor(-2.3f);
            Assert.AreEqual(-3, result2);
        }
    }
}
