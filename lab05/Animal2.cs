using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session7
{
    class Animal2
    {
        protected string Food;
        protected string Activity;
    }
    class Cat : Animal2
    {
        static void Main(String[] args)
        {
            Cat objCat = new Cat();
            objCat.Food = "Mouse";
            objCat.Activity = "laze around";
            Console.WriteLine("The Cat loves to eat" + objCat.Food + ".");
            Console.WriteLine("The Cat loves to" + objCat.Activity + ".");
            Console.Read();
        }
    }
}

