using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Contructor
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                KhachHang a = new KhachHang();
                a.In();
                KhachHang b = new KhachHang(3, "Teo");
                b.In();

                Console.Read();
            }

        }
    }
}
