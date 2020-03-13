using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLap2_OOP
{
    class Derived
    {
        class Derived : Base
        {
            public Derived(string var)
            {
                Console.WriteLine("In Derived constructor. Constructorparameter value: " + var);
            }

            public override void Method1()
            {
                Console.WriteLine("In derived Method1");
            }
            public new void Method2()
            {
                Console.WriteLine("In derived Method2");
            }
        }
    }
}
