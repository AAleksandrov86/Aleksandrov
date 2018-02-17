using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача16
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int max;
            if(x>y)
            {
                max = x;
                
            }
            else max = y;
            if (max>z)
            {
                Console.WriteLine(max);
                return;
            }
            Console.WriteLine(z);








        }
    }
}
