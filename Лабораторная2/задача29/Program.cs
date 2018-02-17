using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача29
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double r;
            if (x < 5)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным ");
                return;
            }
            
            r = (Math.Sqrt(x + 5) + Math.Sqrt(x - 5)) / (2 * Math.Sqrt(x));

            Console.Write("{0:F6}\n", r);

        }
    }
}
