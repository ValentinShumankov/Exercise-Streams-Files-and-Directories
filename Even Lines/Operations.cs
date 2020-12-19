using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Even_Lines
{
    class Operations
    {
        public static string [ ] EvenLineSeparator( string [ ] input )
        {
            List<string> evenLines = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenLines.Add(input [ i ]);
                }
            }
            return evenLines.ToArray( );
        }

        public static string [ ] ReverseLines( string [ ] input )
        {
            for (int i = 0; i < input.Length; i++)
            {
                input [ i ] = string.Join(" ", input [ i ].Split().Reverse( ));
            }
            return input;
        }

        public static string [ ] ReplaceSymbols( string [ ] input )
        {
            for (int i = 0; i < input.Length; i++)
            {
                Regex pattern = new Regex(@"[-,.!?]");
                input [ i ] = pattern.Replace(input [ i ], "@");
            }
            return input;
        }
    }
}
