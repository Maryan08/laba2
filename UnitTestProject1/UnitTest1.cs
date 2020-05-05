using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float[] a = { 4, -4, -12, 12, 3 };
            int m = 5;
            int result = OOP_Lab_2._4.Program.First(a, m);
            Assert.AreEqual(2, result);
        }
    }
}
