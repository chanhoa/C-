using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ex10
    {
        static void code10()
        {
            int num = 1;
            Console.WriteLine("Even Numbers");
            do
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
            } while (num <= 11);
        }
    }
}
