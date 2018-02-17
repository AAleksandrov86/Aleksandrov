using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача22
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int grad = int.Parse(Console.ReadLine());
            double g;
            g = 9.8067;
                    
            if (m <= 0)
            {
                Console.Write("Масса должна быть положительной\n");
                return;
            }
            double f;
            f = m * g * Math.Cos(grad * Math.PI / 180);
            Console.Write("{0:F4}\n", f);





        }
    }
}
