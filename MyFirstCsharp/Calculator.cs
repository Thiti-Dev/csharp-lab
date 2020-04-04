using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCsharp
{
    class Calculator
    {
        static public void TurnOn()
        {
            string operation_str;
            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("Please select the operation");
            Console.WriteLine("Avialable operators = +,-,*,/,%");
            Console.Write("Enter the operation that you wanna use : ");
            operation_str = Console.ReadLine();
            int number_1, number_2;
            Console.Write("Enter the first number : ");
            number_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second first number : ");
            number_2 = Convert.ToInt32(Console.ReadLine());
            switch (operation_str)
            {
                case "+":
                    Console.WriteLine("The result of {0}{1}{2} = {3}", number_1, operation_str, number_2, number_1 + number_2);
                    break;
                case "-":
                    Console.WriteLine("The result of {0}{1}{2} = {3}", number_1, operation_str, number_2, number_1 - number_2);
                    break;
                case "*":
                    Console.WriteLine("The result of {0}{1}{2} = {3}", number_1, operation_str, number_2, number_1 * number_2);
                    break;
                case "/":
                    Console.WriteLine("The result of {0}{1}{2} = {3}", number_1, operation_str, number_2, number_1 / number_2);
                    break;
                case "%":
                    Console.WriteLine("The result of {0}{1}{2} = {3}", number_1, operation_str, number_2, number_1 % number_2);
                    break;
                default:
                    Console.WriteLine("The operation of ({0}) is not recognized by this calculator", operation_str);
                    break;
            }
        }
    }
}
