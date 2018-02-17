using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double r;
            if (a == 0)
            {
                Console.Write("Значение a должно быть не равно нулю\n");
                return;
            }
            if (d == 0)
            {
                Console.Write("Значение d должно быть не равно нулю\n");
                return;
            }
            
            r = (a * d + b * c) / (a * d);

            Console.Write("{0:F4}\n", r);


        }
    }
}
