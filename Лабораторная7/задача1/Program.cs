using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача1
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "abcdefwxyz";
            string b = Console.ReadLine();
            
            if (a.Contains(b))
            {
                Console.WriteLine("Содержит");
                return;
            }
            else
            {
                Console.WriteLine("Не содержит");
            }

        }
    }
}
