using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача30
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double r;
            r = (Math.Sin(a * Math.PI / 180) * Math.Cos(b * Math.PI / 180))+(Math.Sin(b * Math.PI / 180) * Math.Cos(a * Math.PI / 180));
            
            Console.Write("{0:F4}\n", r);

        }
    }
}
