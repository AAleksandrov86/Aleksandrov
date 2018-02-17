using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sk =double.Parse(Console.ReadLine());
            double Skv = double.Parse(Console.ReadLine());
            double rk, rkv;

            if (Sk<0)
            {
                Console.WriteLine("Площадь круга должна быть положительной");
                return;
            }
            if(Skv < 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной");
                return;
            }

            rk =Math.Sqrt(Sk/Math.PI);
            rkv =Math.Sqrt(Skv);

            if (rkv>=rk*rk)
            
            {
                Console.WriteLine("Круг уместится в квадрате");
                return;
            }


            Console.WriteLine("Круг не поместится в квадрате");



        }
    }
}
