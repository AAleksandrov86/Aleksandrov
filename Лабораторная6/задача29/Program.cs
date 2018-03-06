using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача29
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;

            if (y <= 0)
            {
                Console.WriteLine("Значение Y должно быть положительным");
                return;
            }
            while (a <= y)
            {
                a++;
                if (y % a == 0)
                {
                    b++;
                }
            }
            if (b == 2)
            {
                Console.WriteLine("число простое");
            }
            else
            {
                Console.WriteLine("число не простое");
                return;
            }


        }
    }
}
