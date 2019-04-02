using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            double x = 10;
            double y = 20;
            double expected = 30;

            SomeClass c = new SomeClass();
            double actual = c.Summ(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
