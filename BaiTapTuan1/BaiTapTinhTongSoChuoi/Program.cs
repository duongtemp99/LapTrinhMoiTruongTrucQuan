using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTinhTongSoChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Tinh Tong Chuoi Chuoi *******");
            int x, n;
            double s = 0;
            Console.Write("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap  n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                s = s + (Math.Pow(x, i) / GiaiThua(i));
                
            }
            Console.WriteLine("S(" + x + "," + n + ")=" + Math.Round(s, 3));

            double GiaiThua(Double a)
            {
                double gt = 1;
                for (int i = 1; i <= a; i++)
                {
                    gt = gt * i;
                }
                return gt;
            }
            Console.ReadLine();
        }
    }
}
