using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = Convert.ToDouble(Console.ReadLine());
            if (R<=0)
            { Console.WriteLine("Радиус должен быть положительным");
                return;
            }

            Double S;
            S = 2 * Math.PI * R;
            Console.WriteLine("{0:F4}", S);
            









        }
    }
}
