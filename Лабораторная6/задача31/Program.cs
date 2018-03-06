using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача31
{
    class Program
    {
        static void Main(string[] args)
        {

            int w = int.Parse(Console.ReadLine());
            int i = 0;
            int i2 = 0;

            if (w < 0 || w > 20)
            {
                Console.WriteLine("Значение w должно быть в интервале[0, 20]");
                return;
            }
            while (i2 < 10)
            {
                while (i < w)
                {
                    Console.Write(i2);
                    i++;
                }
                Console.WriteLine();
                i = 0;
                i2++;
            }

        }
    }
}
