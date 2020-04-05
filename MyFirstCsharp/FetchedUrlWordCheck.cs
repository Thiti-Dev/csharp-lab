using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MyFirstCsharp
{
    class FetchedUrlWordCheck
    {
        public static void Start()
        {
            string word, url;
            Console.Write("Please enter the url : ");
            url = Console.ReadLine();
            Console.Write("Please enter the word : ");
            word = Console.ReadLine();

            WebClient wc = new WebClient();
            string fetched_content = wc.DownloadString(url);

            string[] words = fetched_content.Split(' ');

            foreach(string _word in words)
            {
                if(_word == word)
                {
                    //found
                    Console.WriteLine($"{word} is found in the webContent");
                    break;
                }
            }
        }
    }
}
