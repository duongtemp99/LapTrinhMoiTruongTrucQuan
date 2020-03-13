using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLap2_Interface
{
    class Listener
    {
        //instance function that matches signature of delegate above 
        public void GetNotified(string sInfo)
        {
            Console.WriteLine("I got notified with the following information {0}", sInfo);
        }

        //static function that matches signature of delegate above
        public static void GetNotifiedAgain(string sInfo)
        {
            Console.WriteLine("I got notified with the following information:{0}", sInfo);
        }
    }
}
