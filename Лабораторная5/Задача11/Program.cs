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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < b)
            {

                if (b < c)
                {
                    Console.WriteLine("выполняется");
                    return;
                }

            }

            Console.WriteLine("невыполняется");







        }
    }
}
