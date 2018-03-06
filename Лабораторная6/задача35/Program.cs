using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача35
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int i2 = 0;

            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            if (h == 0)
            {
                return;
            }
            while (i < h)
            {
                i++;
                while (i2 < i)
                {
                    Console.Write(s);
                    i2++;
                }
                i2 = 0;
                Console.WriteLine();
            }

        }
    }
}
