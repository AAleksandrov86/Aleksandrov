using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача18
{
    class Program
    {
        static void Main(string[] args)
        {

            int schet = 0;
            int s = 0;
            while (s <= 1000)
            {
                int a = int.Parse(Console.ReadLine());
                s=s+a;
                schet++;
            }
            Console.WriteLine(schet);

        }
    }
}
