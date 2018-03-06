using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача19
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int r = 0;
            int l = 0;

            while (a <= 83 || a >= 199)
            {
                a = int.Parse(Console.ReadLine());

                if (a <= 83 || a >= 199)
                {
                    if (a >= 199)
                    {
                        r++;
                    }
                    if (a <= 83)
                    {
                        l++;
                    }
                }
            }
            Console.WriteLine("Количество слева: " + l + ",количества справа: " + r);

        }
    }
}
