using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача7
{
    class Program
    {
        static void Main(string[] args)
        {
            double kr = double.Parse(Console.ReadLine());
            double kv = double.Parse(Console.ReadLine());
            

            if (kr < 0)
            {
                Console.WriteLine("Радиус должен быть положительным ");
                return;
            }

            if (kv < 0)
            {
                Console.WriteLine("Сторона квадрата должна быть положительна ");
                return;
            }

            kr = Math.PI * (kr * kr);
            kv=kv*kv;

            

            

            if (kv > kr)
            {
                Console.WriteLine("Площадь квадрата "+"{0:F4}{1:F4}", kv + " больше площади круга ", kr);
                return;
            }
            else
            {
                 Console.WriteLine("Площадь круга " + "{0:F4}{1:F4}", kr + " больше площади квадрата ", kv);
                return;
                
            }



         
















        }
    }
}
