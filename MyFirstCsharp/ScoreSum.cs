using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCsharp
{
    class ScoreSum
    {
        static public void Start()
        {
            int[] scores;
            int sum = 0;
            Console.WriteLine("Welcome to our score sum console application");
            Console.Write("Please tell me how many students that you have? : ");
            int total_student = Convert.ToInt32(Console.ReadLine());
            scores = new int[total_student];

            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Enter the student {0} score : ", i+1);
                scores[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + scores[i]; // store sum after the value is assigned
            }

            Console.WriteLine("The sum of all the students scores is {0}", sum);

            Console.Write("Do you want to iterate thru all of the student score ? ( y or n ) : ");
            switch (Console.ReadLine())
            {
                case "y":
                    foreach(int _score in scores)
                    {
                        Console.WriteLine("Score : " + _score);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
