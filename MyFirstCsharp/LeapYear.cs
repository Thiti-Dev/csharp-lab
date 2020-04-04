using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCsharp
{
    class LeapYear
    {
        public static void IsLeapYear()
        {
            // LeapYear is the year that divisible by 4
            // But a year that is divisible by 100 is not a leap year
            // it is als divisible by 400


            Console.WriteLine("Please enter the year and we'll tell you if it is a leap year or not");
            int test1, test2, test3;
            Start:
                Console.Write("Enter the year : ");
                try
                {
                    int year = Convert.ToInt32(Console.ReadLine());
                    test1 = year % 4;
                    test2 = year % 100;
                    test3 = year % 400;
                    //Console.WriteLine((year % 4 == 0) ? "This is the leap year" : "this is not the leap year");
                    if((test1 == 0 && test2 != 0) || test3 == 0)
                    {
                        Console.WriteLine("This is the leap year");
                    }
                    else
                    {
                        Console.WriteLine("This is not the leap year");
                    }
                }
                catch (FormatException) // catch specific exception
                {
                    Console.WriteLine("Please enter the integer number");
                    goto Start;
                }
            }
    }
}
