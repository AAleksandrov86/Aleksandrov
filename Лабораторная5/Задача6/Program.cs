using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача6
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c;

            if (a<0)
            {
                Console.WriteLine("Значение velocityInKmH должно быть неотрицательным");
                return;


            }

            if (b < 0)
            {
                Console.WriteLine("Значение velocityInMS должно быть неотрицательным");
                return;


            }



            c = 3.6;
            c = b * c;

            if (a > c)
            {
                Console.WriteLine("{0:F2}{1:F2}" +
                    "", b + " м/с меньше " ,a+" км/ч");
                
                return;
            }

            Console.WriteLine("{0:F2}{1:F2}" +
                    "", a + " км/ч меньше ", b+" м/с");



















        }
    }
}
