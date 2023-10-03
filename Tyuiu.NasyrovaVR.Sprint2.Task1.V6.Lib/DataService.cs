﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NasyrovaVR.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | (c == d);
            res[1] = (a > b) & (c < d);
            res[2] = (a != b) || (c == d);
            res[3] = (a >= b) && (c <= d);
            res[4] = !(res[3]);
            res[5] = (a > b) ^ (c != d);

            return res;
        }
    }
}