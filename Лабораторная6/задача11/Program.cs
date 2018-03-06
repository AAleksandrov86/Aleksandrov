using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача11
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b;
            b = 0;

            if (a < -100 || a > 500)
            {
                Console.WriteLine("Значение a должно быть в интервале [-100, 500]");
                return;
            }
            while (a <= 500)
            {
                b=b+a;
                a++;
            }
            Console.WriteLine(b);

        }
    }
}
