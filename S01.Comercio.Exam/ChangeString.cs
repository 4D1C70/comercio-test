using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S01.Comercio.Exam
{
    public class ChangeString
    {
        private static readonly List<string> alphabet = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public static string build(string value)
        {
            if (value == null) throw new ArgumentException("value cannot be null");

            var temp = new StringBuilder(value.Length);
            var mustUpper = false;
            string replaceValue = string.Empty;
            foreach (var item in value)
            {
                mustUpper = false;
                replaceValue = item.ToString();
                var index = alphabet.IndexOf(item.ToString());
                if (index < 0)
                {
                    index = alphabet.FindIndex(m => item.ToString() == m.ToUpper());
                    if (index >= 0)
                        mustUpper = true;
                }

                if (index >= 0)
                {
                    if (index == alphabet.Count)
                    {
                        replaceValue = mustUpper ? alphabet[index].ToUpper() : alphabet[index]; //For handling last item of alphabet
                    }
                    replaceValue = mustUpper ? alphabet[index + 1].ToUpper() : alphabet[index + 1];
                }

                temp.Append(replaceValue);
            }

            return temp.ToString();
        }


    }
}
