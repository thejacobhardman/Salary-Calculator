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
            double hourlyRate;
            double hoursWorked;
            double overtimeHours;
            double basePay;
            double overtimePay;
            double totalPay;
            string userInput;
            double taxRate;
            double taxAmount = 0.00;
            Boolean userConfirm = false;

            Console.Write("Please enter the hourly rate for this employee: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the hours worked by this employee: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());

            if (hoursWorked > 40.00)
            {
                overtimeHours = hoursWorked - 40.00;
                hoursWorked = 40.00;

                basePay = hoursWorked * hourlyRate;
                overtimePay = overtimeHours * (hourlyRate * 1.50);

                totalPay = Math.Round(basePay + overtimePay, 2, MidpointRounding.AwayFromZero);
            } else
            {
                totalPay = Math.Round(hoursWorked * hourlyRate, 2, MidpointRounding.AwayFromZero);
            }

            while (userConfirm == false) {
                Console.Write("Does this employee need taxes withheld from their pay? (Y/N): ");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == "Y")
                {
                    Console.Write("Please enter the tax rate as an integer: ");
                    taxRate = Convert.ToDouble(Console.ReadLine());
                    taxRate /= 100;
                    taxAmount = Math.Round(totalPay * taxRate, 2 , MidpointRounding.AwayFromZero);
                    totalPay -= taxAmount;
                    break;
                } else if (userInput == "N")
                {
                    break;
                } else
                {
                    Console.WriteLine("Please enter a valid selection.");
                }
            }

            Console.WriteLine("Pay for the employee is: $" + totalPay.ToString("F"));
            if (taxAmount != 0.00)
            {
                Console.WriteLine("The employee had $" + taxAmount.ToString("F") + " witheld from their paycheck.");
            }
            Console.WriteLine("Press 'enter' to exit the progarm.");
            Console.ReadLine();
        }
    }
}
