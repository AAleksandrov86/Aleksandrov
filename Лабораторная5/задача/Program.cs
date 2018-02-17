using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a!=b)
            {
                if (b!=c)
                {
                    if (a!=c)
                    {
                        Console.WriteLine("Числа не равны друг другу");
                        return;
                    }
                }
            }

            Console.WriteLine("Среди чисел есть равные");









        }
    }
}
