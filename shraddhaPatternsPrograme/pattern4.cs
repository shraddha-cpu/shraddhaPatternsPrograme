using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddhaPatternsPrograme
{
    internal class pattern4
    {                               // A
                                    // AB
                                    // ABC
                                    // ABCD
                                    // ABCDE
        static void Main(string[] args)
        {
            for (char i = 'A'; i<='E'; i++)
            {
                for (char j = 'A'; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
