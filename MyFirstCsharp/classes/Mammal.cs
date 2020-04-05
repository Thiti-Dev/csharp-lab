using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCsharp.classes
{
    class Mammal : Animal
    {
        public bool fur;
        public string name;
        public override int LegCount()
        {
            return 4; // default
        }
        public void Print()
        {
            Console.WriteLine($"I am a {name}");
            if (this.fur)
            {
                Console.Write(" and i am fur");
            }
            else
            {
                Console.Write(" and i am not fur");
            }
        }

    }
}
