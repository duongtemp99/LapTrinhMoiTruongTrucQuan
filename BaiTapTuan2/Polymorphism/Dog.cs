using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
	class Dog : Animal
	{
		public Dog()
		{
			Console.WriteLine("Dog constructor");
		}
		public override void Talk()
		{
			Console.WriteLine("Dog talk");
		}

	}
}
