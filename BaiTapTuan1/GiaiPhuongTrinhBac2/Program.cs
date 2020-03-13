using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
			double a, b, c, d;
			Console.WriteLine("**** Giai Va Bien Luan Phuong Trinh Bat 2 ****");
			Console.Write("nhap so a:");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("nhap so b:");
			b = Convert.ToInt32(Console.ReadLine());
			Console.Write("nhap so c:");
			c = Convert.ToInt32(Console.ReadLine());
			if (a == 0)
			{
				if (b == 0)
				{
					if (c == 0)
						Console.WriteLine("Phuong trinh co vo so nghiem.");
					else
						Console.WriteLine("Phuong trinh vo nghiem.");
				}
				else
					Console.WriteLine("Phuong trinh co nghiem duy nhat la: " + -c / b);
			}
			else
			{
				d = Math.Pow(b, 2) - 4 * a * c;
				if (d < 0)
					Console.WriteLine("Phuong trinh vo nghiem..");
				else if (d == 0)
					Console.WriteLine("Phuong trinh co nghiem kep la: " + -b / (2 * a));
				else
					Console.WriteLine("Phuong trinh co 2 nghiem phan biet la: " + (-b + Math.Sqrt(d)) / (2 * a) + " , " + (-b - Math.Sqrt(d)) / (2 * a));
			}
			Console.ReadLine();
		}
    }
}
