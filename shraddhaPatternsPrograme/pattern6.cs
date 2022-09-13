using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shraddhaPatternsPrograme
{
    internal class pattern6
    {                                   //      *
                                        //     * *
                                        //    * * *
                                        //   * * * *
        static void Main(string[] args)
        {

            for (int i = 1; i<=4; i++)
            {
                for (int j = i; j<4; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k<(i*2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
