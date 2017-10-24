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
            String a;
            a = Console.ReadLine();
            Double A;
            A = Double.Parse(a);
            if (A<=0)
            { Console.WriteLine("Значение должно быть положительным");
                return;
            }
            Double V;
            V = 4*Math.PI*(A*A*A)/3;
            Console.WriteLine("{0:F4}",V);










        }
    }
}
