using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача17
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int s;
            if (p<=0)
            {
                Console.WriteLine("Значение P должно быть не равно нулю");
                return;
            }
            s = m % p;
            if(s!=0)
            {
               Console.WriteLine("M не делится нацело на P");
                return;
            }
            s = m / p;
            Console.WriteLine(s);






        }
    }
}
