using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
	enum Days
	{
		//mac dinh  Phan tu  dau tien bat tu 0
		Sat,
		Sun,
		Mon,
		Tue,
		Wed,
		Thu,
		Fri
	};

	class Program
    {
        static void Main(string[] args)
        {
			int x = (int)Days.Sun;
			int y = (int)Days.Fri;
			Console.WriteLine("Sun = {0} : Value : {1}", x, Days.Sun);
			Console.WriteLine("Fri = {0} : Value : {1}", y, Days.Fri);
			Console.Read();
		}
    }
}
