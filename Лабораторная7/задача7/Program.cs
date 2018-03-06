using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            if (a.Length < 12)
            {
                Console.WriteLine("Некорректная длина штрих-кода");
                return;
            }
            string b = a.Substring(0,2);
            string c = a.Substring(3,3);
            string d = a.Substring(7,4);
            string e = a.Substring(12,1);
            Console.WriteLine("Код страны:"+b+"\nКод изготовителя:"+c+ "" +
                "\nКод товара:"+d+ "\nКонтрольное число:" + e);


        }
    }
}
