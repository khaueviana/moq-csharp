using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod3()
        {
            Assert.ThrowsException<NotImplementedException>(() => new Boo().Error());
        }

        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var a = 1;
            var b = 2;

            // act
            var result = new Boo().Sum(a, b);

            // assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            var a = 1;
            var b = 2;

            // act
            var result = new Boo().Sum(1, 2);

            // assert
            Assert.AreEqual(3, result);
        }

        [DataTestMethod]
        [DataRow(1, 2, DisplayName = "Bla bla 1")]
        [DataRow(2, 3, DisplayName = "Bla bla 2")]
        [DataRow(4, 5, DisplayName = "Bla bla 3")]
        public void TestMethod4(int a, int b)
        {
            Assert.AreEqual(a + b, new Boo().Sum(a, b));
        }
    }
}
