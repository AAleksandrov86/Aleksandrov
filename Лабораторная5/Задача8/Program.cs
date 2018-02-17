using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d,r;
            
           
            


            if (a!=0) 
            {
                
            
            r= (b * b - 4 * a * c);

            if (r>=0) 
            {
                if (r>0)
                {
                    Console.WriteLine("У уравнения "+a + "x^2+" + b + "x+" + c + "=0"+ " два вещественных корня");
                    return;
                }

                Console.WriteLine("Уравнение " + a + "x^2+" + b + "x+" + c + "=0" + " имеет один корень");
                return;

            }


            Console.WriteLine("Вещественных корней уравнения "+a+"x^2+"+b+"x+"+c+"=0 нет" );
            return;
            }

            Console.WriteLine("Данное уравнение не является квадратным");
        }
    }
}
