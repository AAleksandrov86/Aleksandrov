using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача16
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double s = 0;
            double b = 1;
            if (a <= 0)
            {
                Console.WriteLine("Значение A должно быть положительным");
                return;
            }
            else
            {
                while (b <= a)
                {
                    s=s+ 1 / b;
                    b++;
                }
            }
            Console.WriteLine("{0:F4}", s);

        }
    }
}
