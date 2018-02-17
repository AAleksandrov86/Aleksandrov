using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача31
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double x = double.Parse(Console.ReadLine());
            double y;
            y = 7 * Math.Pow(x, 2) - 3 * x + 6;

            Console.Write("{0:F0}\n", y);


        }
    }
}
