using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача17
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = 0;
            int schet = 1;
            while (a != 0)
            {
                b = b + a;
                schet++;
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма чисел:" + b + "Количество чисел:" + schet);

        }
    }
}
