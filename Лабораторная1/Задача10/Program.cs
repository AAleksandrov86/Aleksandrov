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
            string a, b, c;
            a = Console.ReadLine();
            b = Console.ReadLine();
            int A, B;
            A = int.Parse(a);
            B = int.Parse(b);
            c = ("INSERT INTO points (x, y) VALUES ");
            


            Console.WriteLine(c+"('"+A+"',"+B+"')");




        }
    }
}
