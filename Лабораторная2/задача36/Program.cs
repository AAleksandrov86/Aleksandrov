﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача36
{
    class Program
    {
        static void Main(string[] args)
        {

            double Xa = double.Parse(Console.ReadLine());
            double Ya = double.Parse(Console.ReadLine());
            double Xb = double.Parse(Console.ReadLine());
            double Yb = double.Parse(Console.ReadLine());
            double r;

            r = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));
            Console.Write("{0:F4}\n", r);

        }
    }
}
