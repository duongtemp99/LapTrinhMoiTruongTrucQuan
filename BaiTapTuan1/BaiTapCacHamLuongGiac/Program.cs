using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCacHamLuongGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x, a;
            Console.WriteLine("***** CAC HAM LUONG GIAC *****");
            Console.Write("Nhap vao 1 goc: ");
            x = Convert.ToInt32(Console.ReadLine());
            a = x * Math.PI / 180;
            Console.WriteLine("Sin<" + x + "> la: " + Math.Sin(a));
            Console.WriteLine("Cos<" + x + "> la: " + Math.Cos(a));
            Console.WriteLine("Tan<" + x + "> la: " + Math.Tan(a));
            Console.WriteLine("CogTan<" + x + "> la: " + 1 / Math.Tan(a));
            Console.Write("Nhan Enter de ket thuc ");
            Console.ReadLine();
        }
    }
}
