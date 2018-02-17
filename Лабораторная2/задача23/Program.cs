using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача23
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double d;
            if (a == 0)
            {
                Console.Write("Данное уравнение не является квадратным\n");
                return;
            }
            d = b * b - 4 * a * c;
            Console.Write("{0:F4}\n", d);

        }
    }
}
