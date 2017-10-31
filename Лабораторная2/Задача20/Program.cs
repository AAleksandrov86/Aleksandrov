using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача20
{
    class Program
    {
        static void Main(string[] args)
        {

            double m = double.Parse(Console.ReadLine());
            double v = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            if (m < 0)
            {
                Console.WriteLine("Значение m должно быть положительным");
                return;
            }
            if (v < 0)
            {
                Console.WriteLine("Значение v должно быть положительным");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Значение h должно быть положительным");
                return;
            }
            double g, ke, pe;
            g = 9.8067;
            ke = m * v * v / 2;
            pe = m * g * h;
            Console.WriteLine("Кинетическая энергия составляет: " +
                "{0:F4}",ke+" Дж");
            Console.WriteLine("Потенциальная энергия составляет: " +
                "{0:F4}",pe+" Дж");








        }
    }
}
