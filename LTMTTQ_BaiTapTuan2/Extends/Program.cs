using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends
{
    class Program
    {
        static void Main(string[] args)
        {
            MicrosoftSoftware objMS = new MicrosoftSoftware();

            IBM objIBM1 = new IBM(50);

            IBM objIBM2 = new IBM("test", 75);

            Console.ReadLine();
        }
    }
}
