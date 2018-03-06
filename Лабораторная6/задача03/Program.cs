using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача03
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Значение a должно быть не больше значения b ");
                return;
            }
            while (b >= a)
            {
                Console.WriteLine(a);
                a++;

            }
        }
    }
}