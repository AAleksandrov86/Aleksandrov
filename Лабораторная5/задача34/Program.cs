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
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (w <= 0)
            {
                Console.WriteLine("Значение w должно быть положительным ");
                return;
            }
            if (h <= 0)
            {
                Console.WriteLine("Значение h должно быть положительным ");
                return;
            }
            if (c <= 0)
            {
                Console.WriteLine("Значение c должно быть положительным ");
                return;
            }
            if (d <= 0)
            {
                Console.WriteLine("Значение d должно быть положительным ");
                return;
            }

            int x1 = (h / c) * (w / d);
            int x2 = (w / c) * (h / d);

            if (x1 > x2)
            {
                Console.WriteLine("{0} при С вдоль h", x1);
            }
            else
            {
                Console.WriteLine("{0} при С вдоль w", x2);
            }

        }
    }
}
