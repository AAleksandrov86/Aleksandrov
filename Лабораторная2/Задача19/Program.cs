using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача19
{
    class Program
    {
        static void Main(string[] args)
        {

            double i = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            if (t < 0)
            {
                Console.WriteLine("Время должно быть положительным");
                return;
            }
            if (i < 0)
            {
                Console.WriteLine("Начальная скорость должно быть неотрицательна");
                return;
            }
            double r;
            r = i * t +(a*t*t/2);
            Console.WriteLine("{0:F2}",r);







        }
    }
}
