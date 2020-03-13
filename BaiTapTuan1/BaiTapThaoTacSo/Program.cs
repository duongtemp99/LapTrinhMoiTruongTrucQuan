using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThaoTacSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nTong = 0, nHieu = 0, nTich = 0, nThuong = 0;
            Console.Clear();
            Console.WriteLine("{0}", "Nhap So Thu nhat: ");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap So Thu hai: ");
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nTong = nSo1 + nSo2;
            nHieu = nSo1 - nSo2;
            nThuong = nSo1 / nSo2;
            nTich = nSo1 * nSo2;
            Console.WriteLine("Tong cua " + nSo1 + " va " + nSo2 + " la " + nTong);
            Console.WriteLine("Hieu cua " + nSo1 + " va " + nSo2 + " la " + nHieu);
            Console.WriteLine("Tich cua " + nSo1 + " va " + nSo2 + " la " + nTich);
            Console.WriteLine("Thuong cua " + nSo1 + " va " + nSo2 + " la " + nThuong);
            Console.ReadLine();
        }
    }
}
