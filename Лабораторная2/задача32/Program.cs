using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача32
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b;
            b = 12 * Math.Pow(a, 2) + 7 * a - 16;
            Console.Write("{0:F4}\n", b);


        }
    }
}
