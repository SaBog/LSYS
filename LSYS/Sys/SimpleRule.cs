using System;

namespace LSYS.Sys
{
    public class SimpleRule
    {
        public char from;
        public string to;

        public SimpleRule(char from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public static SimpleRule[] FromString(string input, string[] separator)
        {
            var array = input.Split(separator, StringSplitOptions.None);
            var ouputArray = new SimpleRule[array.Length / 2];

            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i].Length > 0)
                {
                    var from = array[i][0];
                    var to = array[i + 1];

                    ouputArray[i / 2] = new SimpleRule(from, to);
                }
            }

            return ouputArray;
        }

        public override string ToString()
        {
            return $"{from}→{to}";
        }
    }
}
