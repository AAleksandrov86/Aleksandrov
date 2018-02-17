using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double r;
            

            r = a * Math.Pow(x, 2) + b * x + c;
            if (r < 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным\n");
                return;
            }
            r = Math.Sqrt(r);
            if (r == 0)
            {
                Console.Write("Знаменатель не может быть равен нулю\n");
                return;
            }
            r = 1 / r;
            Console.Write("{0:F4}\n", r);

        }
    }
}
