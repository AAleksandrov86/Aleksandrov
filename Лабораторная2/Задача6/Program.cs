using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача6
{
    class Program
    {
        static void Main(string[] args)
        {

            string a, b;
            a=Console.ReadLine();
            b=Console.ReadLine();
            Double A, B, S;
            A = Double.Parse(a);
            if (A<=0)
            { Console.WriteLine("Значение a должно быть положительным");
                return;
            }
            B = Double.Parse(b);
            if (B <= 0)
            {
                Console.WriteLine("Значение b должно быть положительным");
                return;
            }
            S = A * B / 2;
            Console.WriteLine("{0:F2}",S);
            







        }
    }
}
