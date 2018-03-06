using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача36
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string x = "";
            string y = ".";

            if (a > b)
            {
                while (b < a)
                {
                    if (b % 2 != 0)
                    {
                        Console.Write(x);
                        Console.WriteLine(b);
                        x=x + y;
                    }
                    b++;
                }
            }
            while (a <= b)
            {
                if (a % 2 != 0)
                {
                    Console.Write(x);
                    Console.WriteLine(a);
                    x=x + y;
                }
                a++;
            }

        }
    }
}
