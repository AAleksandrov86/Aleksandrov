using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача6
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = "abcdefwxyz";
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int i = x.IndexOf(a); 
            if (i < 0)
            {
                Console.WriteLine("Значение a отсутствует в строке");
                return;
            }
            int j = x.IndexOf(b);
            if (j < 0)
            {
                Console.WriteLine("Значение b отсутствует в строке");
                return;
            }

            int a1 = x.IndexOf(a);
            int b1 = x.IndexOf(b);
            if (a1 < b1)
            {
                a1 = a1 + 1;
                b1 = b1 - 1;
                while (a1 < b1)
                {
                    char ch1 = x[a1];
                    Console.Write(ch1);
                    a1++;
                }
            }
            else
            a1 = a1 - 1;
            b1 = b1 + 1;
            while(b1<=a1)
            {
                char ch1 = x[b1];
                Console.Write(ch1);
                b1++;
            }
        }
        
    }
}
