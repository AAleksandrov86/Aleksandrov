using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача12
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            

            switch (s)
            {
                case "a":
                    Console.WriteLine("a+\nb\nc\nd\ne\nf\ng\nh ");
                    break;
                case "b":
                    Console.WriteLine("a\nb+\nc\nd\ne\nf\ng\nh ");
                    break;
                case "c":
                    Console.WriteLine("a\nb\nc+\nd\ne\nf\ng\nh ");
                    break;
                case "d":
                    Console.WriteLine("a\nb\nc\nd+\ne\nf\ng\nh ");
                    break;
                case "e":
                    Console.WriteLine("a\nb\nc\nd\ne+\nf\ng\nh ");
                    break;
                case "f":
                    Console.WriteLine("a\nb\nc\nd\ne\nf+\ng\nh ");
                    break;
                case "g":
                    Console.WriteLine("a\nb\nc\nd\ne\nf\ng+\nh ");
                    break;
                case "h":
                    Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh+ ");
                    break;
                default:
                    Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh ");
                    break;
            }











        }
    }
}
