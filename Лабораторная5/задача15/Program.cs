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

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(a<0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            if (b < 0)
            {
                Console.WriteLine("Значение B должно быть неотрицательным");
                return;
            }
            if (c < 0)
            {
                Console.WriteLine("Значение C должно быть неотрицательным");
                return;
            }

            if (a!=b && a!=c)
            {
                if (b!=c)
                {
                    Console.WriteLine("Треугольник не является равнобедренным");
                    return;
                }
            }

            Console.WriteLine("Треугольник является равнобедренным");



        }
    }
}
