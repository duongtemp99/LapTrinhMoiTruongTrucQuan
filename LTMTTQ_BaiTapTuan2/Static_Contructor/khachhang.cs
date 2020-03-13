using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Contructor
{
    class KhachHang
    {
        private int mMaKH;
        private string mTenKH;
        public KhachHang()
        {
            mMaKH = 0;
            mTenKH = "ABC";
        }
        public KhachHang(int ma, string ten)
        {
            mMaKH = ma;
            mTenKH = ten;
        }
        static KhachHang()
        {
            Console.WriteLine("Static goi 1 lan duy nhat truoc khi tao doi tuong");
        }
        public void In()
        {
            Console.WriteLine("Ma KH: " + mMaKH);
            Console.WriteLine("Ten KH: " + mTenKH);
        }
    }
}
