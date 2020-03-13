using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public virtual void Talk()
        {
            Console.WriteLine("Animal talk");
        }
    }
}
