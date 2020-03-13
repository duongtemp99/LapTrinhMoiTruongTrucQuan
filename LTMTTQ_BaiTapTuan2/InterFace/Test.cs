using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    interface TestInterface
    {
        void Print();

    }
	class Test : TestInterface
	{
		public void Print()
		{
			Console.WriteLine("Print method called");
		}
	}
}
