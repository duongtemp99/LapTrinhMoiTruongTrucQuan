using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Squape
    {
       

        //Khi báo các thành phần 
        private int mSide;

        // Khai báo property
        public int Side
        {
            get
            {
                return mSide;
            }

            set
            {
                if (mSide < 0) return;
                mSide = value;
            }
        }

    }
}
