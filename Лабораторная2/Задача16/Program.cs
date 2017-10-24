using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача16
{
    class Program
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            if (B > 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            double C, D;
            C = A + B;
            if (C > 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }

            D=-5*Math.Sqrt(C);

            Console.WriteLine("{0:F4}", C);








        }
    }
}
