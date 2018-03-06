using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача15
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 20;
            double b;
            double s = 0;
            Console.Write("Ход решения: 0+");
            while (a <= 40)
            {
                b = Math.Pow(a, 3);
                Console.Write(b + "=");
                s += b;
                Console.Write(s + "+");
                a++;
            }
            Console.WriteLine("0 = ");
            Console.WriteLine("Ответ: " + s);

        }
    }
}
