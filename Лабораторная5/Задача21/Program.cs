﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача21
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (y <= 4 && x >= 1 && x <= 2)
            {
                Console.WriteLine("Точка принадлежит множеству ");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит множеству ");

            }
        }
    }
}
