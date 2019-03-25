using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace S01.Comercio.Exam.Test
{
    [TestClass]
    public class OrderRangeTest
    {
        [TestMethod]
        public void BuildFirstTest()
        {
            var expected = new List<List<int>> { new List<int> { 1, 5 }, new List<int> { 2, 4 } };

            var actual = OrderRange.build(new List<int> { 2, 1, 4, 5 });

            var result = expected.First().SequenceEqual(actual.First()) &&
                         expected.Last().SequenceEqual(actual.Last());

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BuildSecondTest()
        {
            var expected = new List<List<int>> { new List<int> { 2, 4, 6 }, new List<int> { 3, 9 } };

            var actual = OrderRange.build(new List<int> { 4, 2, 9, 3, 6 });

            var result = expected.First().SequenceEqual(actual.First()) &&
                         expected.Last().SequenceEqual(actual.Last());

            Assert.IsTrue(result);
        }



        [TestMethod]
        public void BuildThirdTest()
        {
            var expected = new List<List<int>> { new List<int> { 48, 58, 60 }, new List<int> { 55, 57, 73 } };

            var actual = OrderRange.build(new List<int> { 58, 60, 55, 48, 57, 73 });

            var result = expected.First().SequenceEqual(actual.First()) &&
                         expected.Last().SequenceEqual(actual.Last());

            Assert.IsTrue(result);
        }

    }
}
