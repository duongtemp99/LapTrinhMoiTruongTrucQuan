﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLap2_Interface
{
    interface IHuman
    {
        void Speak(string Message);
        string Name { get; set; }
    }
}
