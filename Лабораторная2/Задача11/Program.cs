using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача11
{
    class Program
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine());
            if (A < 0)
            {
                Console.WriteLine("Значение a недолжно быть отрицательным");
                return;
            }

            double B;
            B = (Math.Sqrt (A));
            Console.WriteLine("{0:F4}",B);











        }
    }
}
