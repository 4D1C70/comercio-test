using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace S01.Comercio.Exam.Test
{
    [TestClass]
    public class ChangeStringTest
    {
        [TestMethod]
        public void BuildFirstTest()
        {
            var expected = "123 bcde*3";
            var actual = ChangeString.build("123 abcd*3");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuildSecondTest()
        {
            var expected = "**Dbtb 52";
            var actual = ChangeString.build("**Casa 52");
            Assert.AreEqual(expected, actual);
        }
    }
}
