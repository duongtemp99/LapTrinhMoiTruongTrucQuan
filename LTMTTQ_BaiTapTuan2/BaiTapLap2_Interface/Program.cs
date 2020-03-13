using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLap2_Interface
{
    class Program
    {
        private delegate void NotifyMe(string s1);
        static void Main(string[] args)
        {
            /* IHuman h;
             Theodore t;
             h = new Theodore();
             //cast for assignement
             t = (Theodore)h;
             //use class based reference
             t.Name = "Fred";
             t.Speak("I like public implementations!");
             //use interface reference
             h.Name = "Teddy";
             h.Speak("I like VB!");*/


            NotifyMe d = new NotifyMe(Listener.GetNotifiedAgain);


            InvokeDelegate(d);

            Listener lsnr = new Listener();

            NotifyMe d2 = new NotifyMe(lsnr.GetNotified);

            InvokeDelegate(d2);

            InvokeDelegate(d);

            Console.Read();
        }
        static void InvokeDelegate(NotifyMe d)
        {
            d("You are late paying your bills!");
        }
    }
}
