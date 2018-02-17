using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            if (x>0)
            {
                x = Math.Pow(x,2);
                
            }
            if (y > 0)
            {
                y = Math.Pow(y, 2);
               
            }
            if (z > 0)
            {
                z = Math.Pow(z, 2);
                
            }

            Console.WriteLine("{0:F4}{1:F4}{2:F4}",x+"; ",y+"; ",z);

        }
    }
}
