using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);
            if (A<=0) 
            { Console.WriteLine("Значение должно быть положительным");
                return;
            }
            int S;
            S =  6*(A*A);
            Console.WriteLine(S);







        }
    }
}
