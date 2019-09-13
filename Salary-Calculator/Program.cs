using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter an integer between 0 and 75: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("That number is too small.");
            } else if (num > 75)
            {
                Console.WriteLine("That number is too large.");
            } else
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine("\nPress 'enter' to continue.");
            Console.ReadLine();
        }
    }
}
