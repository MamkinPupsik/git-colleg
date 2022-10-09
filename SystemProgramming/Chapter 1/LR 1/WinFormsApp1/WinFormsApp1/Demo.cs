using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Demo
    {
        public static long Instances;
        public Demo()
        {
            Instances++;
        }
        ~Demo()
        {
            Instances--;
        }
    }
}
