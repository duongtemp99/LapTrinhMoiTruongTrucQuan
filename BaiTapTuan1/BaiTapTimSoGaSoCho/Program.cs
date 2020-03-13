using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTimSoGaSoCho
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b1, c1, a2, b2, c2;
            double d, dx, dy, x, y;
            Console.WriteLine("**** So Ga So Cho (he phuong trinh 2 an) ****");
            Console.Write("Nhap a: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap a1: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b2: ");
            b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c2: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            d = a1 * b2 - a2 * b1;
            dx = c1 * b2 - c2 * b1;
            dy = a1 * c2 - a2 * c1;
            if (d == 0)
            {
                if (dx + dy == 0)
                {
                    Console.WriteLine("He phuong trinh co vo so nghiem ");
                }
                else
                {
                    Console.WriteLine("He phuong trinh co vo so nghiem ");
                }
            }
            else
            {
                x = dx / d;
                y = dy / d;
                Console.WriteLine("x= " + x);
                Console.WriteLine("y= " + y);
            }


            Console.Read();
        }
    }
}
