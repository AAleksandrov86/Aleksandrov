using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача08
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            int y;
            int z;
            x = 453;
            y = 1;
            z = 1;

            while (y <= 20)
            {
                z = x * y;
                Console.WriteLine("{0}    {1} ", y, z);
                y++;
            }

        }
    }
}
