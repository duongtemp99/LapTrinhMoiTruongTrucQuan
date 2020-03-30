using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.Print();
            //Gọi phương thức Print() bằng  interface  Test
            TestInterface ib = (TestInterface)obj;
            ib.Print();
            //Gọi phuong thức Print() bằng cách ép kiểu Interface TestInterface về lớp Test 
            Test ojB = (Test)ib;
            ojB.Print();
            Console.Read();
        }
    }
}
