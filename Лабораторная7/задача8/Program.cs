using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача8
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "abcdefwxyz";
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = x.Length;
            if(a<0 && d<a)
            {
                Console.WriteLine("Значение a должно быть в интервале [0, длина строки)");
                return;
            }
            if ((a + b) > d)
            {
                Console.WriteLine("Сумма значений a и b должна быть меньше длины строки");
                return;
            }
            if(b<0)
            {
                Console.WriteLine("Значение b должно быть неотрицательно");
                return;
            }
            string c = x.Remove(a,b);
            Console.WriteLine(c);


        }
    }
}
