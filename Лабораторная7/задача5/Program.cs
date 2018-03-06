using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача5
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = "abcdefwxyz";
            int a =int.Parse( Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int y = x.Length;
            if (a > b)
            {
                Console.WriteLine("Значение a должно быть меньше b");
                return;
            }
            if(a<0||a>y)
            {
                Console.WriteLine("Значение a должно быть в интервале [0,длина строки)");
                return;
            }
            if ( b < 0 || b > y)
            {
                Console.WriteLine("Значение b должно быть в интервале [0,длина строки)");
                return;
            }
            
            while (a<=b)
            {
                char ch1 = x[a];
                
                Console.Write(ch1);
                a++;
            }
                






        }
    }
}
