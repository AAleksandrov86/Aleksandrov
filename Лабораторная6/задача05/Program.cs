using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача05
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            int c = 0;

            if (a < 0)
            {
                Console.WriteLine("Значение a должно быть неотрицательным");
                return;
            }
            Console.Write("\"");
            while (c <= a)
            {

                Console.Write(b);
                c++;

            }
            Console.Write("\" ");

        }
    }
}
