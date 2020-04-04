using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCsharp
{
    class GuessMyNumber
    {
       static public void Start()
        {
            int score = 10; // start with 10
            string player_name; // storing the player name
            Console.Write("Welcome to the guessing game \n Please at least tell me what's your name : ");
            player_name = Console.ReadLine();
            int random_number = new Random().Next(1,100);
            Console.WriteLine("Hint the number is : " + random_number);

            

            Guess:
            Console.Write("Tell me that what was the number in your mind : ");
            int guess_number = Convert.ToInt32(Console.ReadLine()); 
                if(guess_number == random_number)
                {
                    Console.WriteLine("That's correct");
                }
                else
                {
                    // keep looping
                    Console.WriteLine("That's not correct");
                score--; // minus the score if answer wrong
                    goto Guess;
                }





            Console.WriteLine("{0} got the score of {1}", player_name, score);
        }
    }
}
