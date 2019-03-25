using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace S01.Comercio.Exam.Test
{
    [TestClass]
    public class MoneyPartsTest
    {
        [TestMethod]
        public void BuildFirstTest()
        {
            //decimal[] l = { 5, 10, 20, 50, 100, 200, 500 };


            decimal[] changes = { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };
            var t = MoneyParts.build("0.5");

        }
    }
}
