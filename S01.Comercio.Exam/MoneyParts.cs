using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace S01.Comercio.Exam
{
    public class MoneyParts
    {
        public static readonly decimal[] changes = { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };
        private static List<List<decimal>> resultList = new List<List<decimal>>();
        public static Array build(string value)
        {
            var decimalValue = decimal.Parse(value,CultureInfo.InvariantCulture);
            var result = GetParts(decimalValue, 0, changes, new List<decimal>());

            return resultList.ToArray<List<decimal>>();
        }

        public static int GetParts(decimal total, int index, decimal[] list, List<decimal> parts)
        {
            if (total == 0)
            {
                var result = new List<decimal>();
                foreach (var i in parts)
                {
                    result.Add(i);
                }
                resultList.Add(result);
                return 1;
            }
            if (index == list.Length)
            {
                return 0;
            }
            int ret = 0;
            for (; total >= 0; total -= list[index])
            {
                ret += GetParts(total, index + 1, list, parts);
                parts.Add(list[index]);
            }
            for (int i = 0; i < parts.Count; i++)
            {
                while (parts.Count > i && parts[i] == list[index])
                {
                    parts.RemoveAt(i);
                }
            }
            return ret;
        }

    }
}
