using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача15
{
    class Program
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine());
            if (A < -273.15)
            {
                Console.WriteLine("Температура должна быть выше абсолютного нуля");
                return;
            }

            double B,C;
            C = 1.8;

            B = ((A*C)+32);

            Console.WriteLine("{0:F4}", B);








        }
    }
}
