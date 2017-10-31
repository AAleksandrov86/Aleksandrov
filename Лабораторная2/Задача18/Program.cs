using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача18
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y;
            y = x1 * x2;
            x1 = x1 * x3;
            x2 = x2 * x3;
            y = y + x1 + x2;
            Console.WriteLine(y);







        }
    }
}
