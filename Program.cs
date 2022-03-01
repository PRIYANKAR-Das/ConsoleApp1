using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program to find the largest of 3 numbers");

            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int result = -1;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    result = num1;
                }
                else
                {
                    result = num3;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    result = num2;
                }
                else
                {
                    result = num3;
                }
            }

            Console.WriteLine("The largest of {0}, {1} and {2} is: {3}", num1, num2, num3, result);

            Console.WriteLine("");

            Console.WriteLine("A program to swap two numbers without using 3rd variable");

            Console.WriteLine("Enter the first number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping x = " + x + " and y = " + y);

            x = x ^ y;
            y = y ^ x;
            x = x ^ y;

            Console.WriteLine("After swapping x = " + x + " and y = " + y);

            Console.WriteLine("");

            Console.WriteLine("Get and print employee details");

            Console.WriteLine("Enter your employeeID:");
            string employeeID = Console.ReadLine();

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your salary:");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("ID: " + employeeID);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);

            Console.ReadLine();
        }
    }
}
