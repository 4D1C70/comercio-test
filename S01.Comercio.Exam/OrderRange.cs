using System.Collections.Generic;
using System.Linq;

namespace S01.Comercio.Exam
{
    public class OrderRange
    {
        public static List<List<int>> build(ICollection<int> collection)
        {
            if (collection == null) throw new System.ArgumentException("collection cannot be null");

            var result = new List<List<int>>();
            var orderedEvenNumbers = collection.Where(m => m % 2 == 0).OrderBy(n => n).ToList();
            var orderedOddNumbers = collection.Where(m => m % 2 != 0).OrderBy(n => n).ToList();

            if (orderedEvenNumbers.First() > orderedOddNumbers.FirstOrDefault())
            {
                result.Add(orderedOddNumbers);
                result.Add(orderedEvenNumbers);
            }
            else
            {
                result.Add(orderedEvenNumbers);
                result.Add(orderedOddNumbers);

            }

            return result;
        }
    }
}
