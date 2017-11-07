using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача5
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double f;

            if (a < 0)
            {
                Console.WriteLine("Значение distanceInKm должно быть неотрицательным ");
                return;
            }

            if (b < 0)
            {
                Console.WriteLine("Значение distanceInFeet должно быть неотрицательным ");
                return;
            }



            f = 0.305;
            b = (b * f)/1000;

            if (a > b)
            {
                Console.WriteLine("Расстояние в футах меньше ");
                return;
            }
             
            Console.WriteLine("Расстояние в километрах меньше ");



















        }
    }
}
