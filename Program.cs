using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            b = 10;
            c = 3;
            c = c * b;
            a = 10 * c % 10;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
