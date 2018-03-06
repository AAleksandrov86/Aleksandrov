using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача11
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            char[] a1 = {'"',' ' };
            
            if (a.StartsWith("\"") && a.EndsWith("\""))
            {
                string b = a.Trim(a1);
                Console.WriteLine(b);
                return;

                
            }
            else
            {
                Console.WriteLine("Строка должна начинаться и заканчиваться кавычкой");
                return;
            }




        }
    }    
}
