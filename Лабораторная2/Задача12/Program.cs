using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача12
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = (Console.ReadLine());
            Double A;
            A = double.Parse(a);
            Double B;
            B = 5*Math.Cos(A * Math.PI / 180);
            Console.WriteLine("{0:F4}", B);








        }
    }
}
