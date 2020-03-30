using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Squape obj = new Squape();
            obj.Side = 5;
            Console.WriteLine("Gia Tri Cua Side la: " + obj.Side);


            Console.Read();
        }
    }
}
