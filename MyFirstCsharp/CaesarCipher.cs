using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCsharp
{
    class CaesarCipher
    {
       static public void Start()
        {
            string base_txt,encrypted_txt = ""; // empty string
            Console.WriteLine("Welcome to my text encrypting console application");
            Console.Write("Please enter the text that you want t to be encrypted : ");
            base_txt = Console.ReadLine();

            int text_length = base_txt.Length;
            Console.WriteLine($"The length of the word : {text_length}");

            foreach(char c in base_txt)
            {
                if (c != ' ')
                {
                    encrypted_txt = encrypted_txt + Convert.ToChar(((int)c + 3));
                }
                else
                {
                    encrypted_txt = encrypted_txt + ' ';
                }
            }

            Console.WriteLine(encrypted_txt);
        }
    }
}
