using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Even_Lines
{
    class Program
    {
        static void Main( string [ ] args )
        {
            string[] textLines = File.ReadAllLines("../../../text.txt"); 
            textLines = Operations.ReplaceSymbols(textLines);
            textLines = Operations.ReverseLines(textLines);
            textLines = Operations.EvenLineSeparator(textLines);
            foreach (var line in textLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
