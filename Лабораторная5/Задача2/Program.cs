using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {

            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            if (p > q)
            {

                Console.WriteLine("Максимальное "+p+"," +" минимальное "+q);
                return;
            }

            Console.WriteLine("Максимальное " + q + "," + " минимальное " + p);








        }
    }
}
