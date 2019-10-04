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
            Console.WriteLine("Enter the number of month");
            while (true)
            {
                int month_selector = Convert.ToInt32(Console.ReadLine());
            
                if (month_selector == 1 | month_selector == 2 | month_selector == 12)
                {
                    Console.WriteLine("Winter");
                }
                else if (month_selector == 3 | month_selector == 4 | month_selector == 5)
                {
                    Console.WriteLine("Spring");
                }
                else if (month_selector == 6 | month_selector == 7 | month_selector == 8)
                {
                    Console.WriteLine("Summer");
                }
                else if (month_selector == 9 | month_selector == 10 | month_selector == 11)
                {
                    Console.WriteLine("Autumm");
                }
                else
                {
                    Console.WriteLine("Wrong month");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
