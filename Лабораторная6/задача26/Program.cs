using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача26
{
    class Program
    {
        static void Main(string[] args)
        {

            int schet = 0;
            int x = 100;
            int y = 1000;

            Console.Write("Ход решения: ");
            while (x <= y)
            {
                if (x % 13 != 0)
                {
                    Console.Write(x + " ");
                }
                else
                {
                    Console.Write(x + "+ ");
                    schet++;
                }
                x++;
            }
            Console.WriteLine("Ответ: " + schet);

        }
    }
}
