using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача8
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A <= 0)
            {
                Console.WriteLine("Значение a должно быть положительным");
                return;
            }
             if (B <= 0)
            {
                Console.WriteLine("Значение b должно быть положительным");
                return;
            }
            int C,D;
            C = A * 100 / B;
            D = A * 100 % B;

            Console.WriteLine(C+"шт "+D+"см");











        }
    }
}
