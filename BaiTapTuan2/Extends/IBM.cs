using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends
{
    class IBM:Software
    {
        public IBM(int y) : base(y)
        {
            Console.WriteLine(m_x);
        }
        public IBM(string s, int f) : this(f)
        {
            Console.WriteLine(s);
        }
    }
}
