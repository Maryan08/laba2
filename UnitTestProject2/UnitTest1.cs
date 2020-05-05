using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float[] a = { 4, -4, -12, 12, 3 };
            int m = 5;
            int index = 2;
            float result = OOP_Lab_2._4.Program.Second(a, m, index);
            Assert.AreEqual(3, result);
        }
    }
}
