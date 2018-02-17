using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача24
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            
            double g;
            g = 9.8067;
            double f;
           
            if (m1 <= 0)
            {
                Console.Write("Масса должна быть неотрицательной\n");
                return;
            }
            if (m2 <= 0)
            {
                Console.Write("Масса должна быть неотрицательной\n");
                return;
            }
            if (d <= 0)
            {
                Console.Write("Дистанция должна быть неотрицательной\n");
                return;
            }
            f = g * m1 * m2 / Math.Pow(d, 2);

            Console.Write("{0:F4}\n", f);



        }
    }
}
