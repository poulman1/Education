using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"First number {a} bigger then second");
            }
            if (b > a)
            {
                Console.WriteLine($"Second number {b} bigger then first");
            }
            Console.ReadKey();
        }
    }
}
