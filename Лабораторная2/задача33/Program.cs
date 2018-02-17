using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача33
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double r;
            r = 6350;
            double result;
            if (x < 0)
            {
                Console.Write("Высота над уровнем Земли должна быть неотрицательна ");
                return;
            }
            result = Math.Sqrt(Math.Pow(r + x, 2) - Math.Pow(r, 2));
            Console.Write("{0:F4}\n", result);

        }
    }
}
