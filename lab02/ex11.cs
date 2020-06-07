using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ex11
    {
        static void code()
        {
            int num;
            Console.WriteLine("Even Numbers");
            for (num = 1; num <= 11; num++)
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
