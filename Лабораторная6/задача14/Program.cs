using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача14
{
    class Program
    {
        static void Main(string[] args)
        {

            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = 1;

            if (a < b)
            {
                while (a <= b)
                {
                    c = c * a;
                    a++;
                }
            }
            else
            {
                while (b <= a)
                {
                    c = c * b;
                    b++;
                }
            }
            Console.WriteLine(c);

        }
    }
}
