using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача20
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double summa = 0;

            if (a >= b)
            {
                while (b <= a)
                {
                    summa += Math.Pow(a, 2);
                    a--;

                }
                Console.WriteLine(summa);
            }
            else
            {
                while (a <= b)
                {
                    summa += Math.Pow(a, 2);
                    a++;
                }
                Console.WriteLine(summa);
            }

        }
    }
}
