using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator");

            Console.WriteLine("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Specify the operation: +, -, *, /");
            char operation = char.Parse(Console.ReadLine());

            double result = -1;
            
            switch(operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

            Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, result);

            Console.ReadLine();
        }
    }
}
