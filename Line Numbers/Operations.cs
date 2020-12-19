using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Line_Numbers
{
    class Operations
    {
        public  static string[] InsertLineNumbers(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int lettersCount = input[i].Where(x => char.IsLetter(x)).ToArray().Length;
                int symbolsCount = string.Join("",input [ i ]
                    .Trim().Split(" ",StringSplitOptions.RemoveEmptyEntries))
                    .Where(x => !char.IsLetterOrDigit(x)).ToArray( ).Length;
                input [ i ] = $"Line {i + 1}: {input[i]}({lettersCount})({symbolsCount})";
            }
            return input;
        }
    }
}
