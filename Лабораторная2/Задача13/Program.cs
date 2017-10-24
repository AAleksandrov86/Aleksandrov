using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача13
{
    class Program
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine());
            double B,C;
            C = 61 - A;
            if (C < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            B = 3*(Math.Sqrt(C));
            
            Console.WriteLine("{0:F4}", B);







        }
    }
}
