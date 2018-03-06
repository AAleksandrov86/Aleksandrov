using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача9
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            if(x.StartsWith("s"))
            {
                Console.WriteLine(x.ToLower());
                return;
            }

            if (x.StartsWith("U"))
            {
                Console.WriteLine(x.ToUpper());
                return;
            }
            Console.WriteLine(x);

        }
    }
}
