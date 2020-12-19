using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main( string [ ] args )
        {
            string[] inputLines = File.ReadAllLines("../../../text.txt");
            inputLines = Operations.InsertLineNumbers(inputLines);
            File.WriteAllLines("../../../outPutLineNumbers.txt", inputLines);
        }
    }
}
