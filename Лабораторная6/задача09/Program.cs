using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача09
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            a = 1;
            int b;
            b = 1;
            while (a <= 9)
            {
                b = a * 7;
                Console.WriteLine("{0} x 7 = {1}", a, b);
                a++;
            }

        }
    }
}
