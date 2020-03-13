using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            int cDai, cRong, nDienTich = 0, nChuVi = 0;
            Console.WriteLine("******** Tinh Chu Vi Va Dien Tich ********");
            Console.Write("Nhap vao chieu dai: ");
            cDai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao chieu rong: ");
            cRong = Convert.ToInt32(Console.ReadLine());
            nChuVi = (cDai + cRong) * 2;
            nDienTich = cDai * cRong;
            Console.WriteLine("Chu Vi= " + nChuVi);
            Console.WriteLine("Dien Tich= " + nDienTich);
            Console.ReadLine();
        }
    }
}
