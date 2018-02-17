using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача37
{
    class Program
    {
        static void Main(string[] args)
        {

            double v1 = double.Parse(Console.ReadLine());
            double t1 = double.Parse(Console.ReadLine());
            double v2 = double.Parse(Console.ReadLine());
            double t2 = double.Parse(Console.ReadLine());
            double v;
            double t;
            if (v1 < 0)
            {
                Console.Write("Объем должен быть неотрицательным ");
                return;
            }
            if (v2 < 0)
            {
                Console.Write("Обьем должен быть неотрицательным ");
                return;
            }
            v = v1 + v2;
            t = (t1 * v1 + t2 * v2) / (v1 + v2);
            Console.Write("{0}\n{1:F4}\n", v, t);

        }
    }
}
