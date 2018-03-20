using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIANA_2._01
{
    public class Runner
    {
        public static void WhatTimeIs()
        {
            Speaker.Speak(DateTime.Now.ToShortTimeString());
        }

        public static void WhatDateIs()
        {
            Speaker.Speak(DateTime.Now.ToShortDateString());
        }
    }
}
