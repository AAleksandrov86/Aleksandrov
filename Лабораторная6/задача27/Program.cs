using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача27
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int summa = 0;

            if (a > b)
            {
                while (a >= b)
                {
                    if (a % 7 == 0)
                    {
                        summa=summa+a;
                    }
                    a--;
                }
            }
            else
            {
                while (a <= b)
                {
                    if (a % 7 == 0)
                    {
                        summa=summa+a;
                    }
                    a++;
                }
            }
            Console.WriteLine(summa);

        }
    }
}
