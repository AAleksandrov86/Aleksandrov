using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача10
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int s;
            a = 100;
            b = 500;
            s = 100;
            while (a <= b)
            {
                Console.Write(s + " ");
                a++;
                s =s+a;
            }
            s = s - a;
            Console.WriteLine("\nОтвет:" + s);
        }

    }
    
}
