using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.Talk();
            Dog dog1 = new Dog();
            dog1.Talk();

            Console.Read();
        }
    }
}
