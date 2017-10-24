using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача14
{
    class Program
    {
        static void Main(string[] args)
        {


            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            if (B > 0)
            {
                Console.WriteLine("Значение B должно быть не положительным");
                return;
            }
            double C;
                        
            C = A * Math.Sqrt(-7*B);

            Console.WriteLine("{0:F4}", C);










        }
    }
}
