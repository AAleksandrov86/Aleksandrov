using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача17
{
    class Program
    {
        static void Main(string[] args)
        {

            double V1 = double.Parse(Console.ReadLine());
            double V2 = double.Parse(Console.ReadLine());
            double R = double.Parse(Console.ReadLine());
            double T,V3;
            V3 = V1 + V2;
            if (V3 < 0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }

            T = R / V3;
            Console.WriteLine(string.Format("{0:F4}",T));
            

            






        }
    }
}
