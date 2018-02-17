using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача34
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result;
            result = 3 * Math.Sin(2 * a * Math.PI / 180) * Math.Cos(3 * b * Math.PI / 180);
            Console.Write("{0:F4}\n", result);

        }
    }
}
