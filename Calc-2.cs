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

            //while (a != int)
            //{
            //    Console.WriteLine("Wrong number");
            //}

            Console.WriteLine("Enter your second number");
            int b = Convert.ToInt32(Console.ReadLine());

            //while (b !=)
            //{
            //    Console.WriteLine("Wrong number");
            //    return;
            //}

            Console.WriteLine("Enter your operator");
            string operators = Console.ReadLine();
            switch (operators)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Wrong operator");
                    break;
            }
            Console.ReadKey();
        }
    }
}
