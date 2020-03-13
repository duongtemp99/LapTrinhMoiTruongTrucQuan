using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
			float soA, soB;
			Console.WriteLine("******** Giai Phuong Trinh Bat 1 ********");
			Console.Write("nhap so a:");
			soA = Convert.ToInt32(Console.ReadLine());
			Console.Write("nhap so b:");
			soB = Convert.ToInt32(Console.ReadLine());
			if (soA == 0)
			{
				if (soB == 0)
					Console.WriteLine("Phuong trinh co vo so nghiem.");
				else
					Console.WriteLine("Phuong trinh vo nghiem.");
			}
			else
				Console.WriteLine("Phuong trinh co nghiem  la: " + -soB / soA);

			Console.ReadLine();
		
	}
    }
}
