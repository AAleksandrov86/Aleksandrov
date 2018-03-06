using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача4
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = "abcdacadbacdaabaadc";
            string y = Console.ReadLine();
            int a = y.Length;
            if(a!=2)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 символа");
                return;
            }
            int n = x.IndexOf(y);
            while (n != -1)
            {
                Console.Write(n + " ");
                n = x.IndexOf(y, n + y.Length);
            }


        }
    }
}
