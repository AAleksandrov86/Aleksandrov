using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача3
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = "abcdefwxyz";
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int ab = x.IndexOf(a);
            int ba = x.IndexOf(b);
            if (ab<0)
            {
                Console.WriteLine("Значение a отсутствует в строке");
                return;
            }
            if (ba < 0)
            {
                Console.WriteLine("Значение a отсутствует в строке");
                return;
            }
            int c = x.Length - ab - 1;
            int d = x.Length - ba - 1;
            if (c > d)
            {
                int r = c - d - 1;
                Console.WriteLine(r);
                return;
            }
            else
            {
                int r = d - c - 1;
                Console.WriteLine(r);
                return;
            }

            

        }
    }
}
