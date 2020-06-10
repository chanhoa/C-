using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinppet6
{
    class animal
    {
        public animal()
        {
            Console.WriteLine("Animal constructor without parameters");
        }
        public animal(String name)
        {
            Console.WriteLine("Animal constructor with a string parameter");
        }

    }
    class Canine : animal
    {
        //base() takes a string value called “Lion”
        public Canine() : base("Lion")
        {
            Console.WriteLine("Derived Canine");
        }
    }
    class Details
    {
        static void Main(String[] args)
        {
            Canine objCanine = new Canine();
            Console.Read();
        }
    }
}
