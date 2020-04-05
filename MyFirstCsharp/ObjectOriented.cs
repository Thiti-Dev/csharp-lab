using MyFirstCsharp.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCsharp
{
    class ObjectOriented
    {
        public static void Start()
        {
            //Creating the person object
            Person user = new Person();
            user.PrintCredential();
            Bat bat = new Bat();
            bat.Print();
        }
    }
}
