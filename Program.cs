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
            //declare needed variables
            double price, discount, sale;  

            //prompt and receive input for item price and discount
            Console.WriteLine("Please input item price in dollars: ");
            price = Double.Parse(Console.ReadLine());  
            Console.WriteLine("Please input discount percent: ");
            discount = Double.Parse(Console.ReadLine());

            //change discount from percent off to decimal representation of original price
            discount = 1 - (discount / 100);   
            sale = price * discount;

            Console.WriteLine($"The discounted price is ${sale}.");
            Console.ReadKey();
        }
    }
}
