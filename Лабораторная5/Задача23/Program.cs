using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача23
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x >= 2 && y >= 0) || (x >= 1 && y <= -1))
            {
                Console.WriteLine("Точка принадлежит множеству ");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит множеству ");

            }
        }
    }
}