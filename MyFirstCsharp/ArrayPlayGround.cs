using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCsharp
{
    class ArrayPlayGround
    {
        static public void Start()
        {
            int[,] food_data = new int[,]
            {
                {123,456 },
                { 345,678}
            };

            Console.WriteLine("Legnth of the array : {0}",food_data[0,0]);
        }
    }
}
