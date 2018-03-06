using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача34
{
    class Program
    {
        static void Main(string[] args)
        {

            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int i2 = 0;

            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            if (w == 0 ||h==0)
            {
                return;
            }
            
            Console.Write(" ");

            while (i < w)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine();
            while (i2 < h)
            {
                i = 0;
                Console.Write(i2);
                while (i < w)
                {

                    Console.Write(".");
                    i++;
                }

                Console.Write("|");
                Console.WriteLine();
                i2++;

            }
            i = 0;
            Console.Write(" ");
            while (i < w)
            {
                Console.Write("_");
                i++;
            }

        }
    }
}
