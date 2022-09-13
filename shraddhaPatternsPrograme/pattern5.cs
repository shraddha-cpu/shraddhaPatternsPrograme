using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddhaPatternsPrograme
{
    internal class pattern5
    {                           // 12345
                                // 1234
                                // 123
                                // 12
                                //1
        static void Main(string[] args)
        {
            for (int i = 5; i>=1; i--)
            {
                for (int J = 1; J<=i; J++)
                {
                    Console.Write(J);
                }
                Console.WriteLine();
            }
        }
    }
}
