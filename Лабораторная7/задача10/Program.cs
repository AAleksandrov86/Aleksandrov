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

            string x = "abcdacadbacdaabaadc";
            string a = Console.ReadLine();
            if (a.Length !=2)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 символа");
                return;
            }
            Console.WriteLine(x.Replace(a,"  "));



        }
    }
}
