using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача9
{
    class Program
    {
        static void Main(string[] args)
        {

            string a,b,c,d;
            a = Console.ReadLine();
            b = ("SELECT first_name,");
            c = (" last_name,");
            d = (" group\n" +
                " FROM students WHERE student_id = ");



            Console.WriteLine(b+c+d+"'"+a+"'");





        }
    }
}
