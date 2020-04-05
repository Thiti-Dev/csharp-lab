using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCsharp.classes
{
    class Person
    {
        private string name,phone;
        private int age;
        private float height;

        public Person()
        {
            name = "Anonymous";
            age = 20;
            height = 180;
        }
        public Person(string _name,int _age,float _height, string _phone)
        {
            this.name = _name;
            this.age = _age;
            this.height = _height;
            this.phone = _phone;
        }
        public void PrintCredential()
        {
            Console.WriteLine($"My name's {this.name}, I am {this.age} years old. \n My height is about {this.height} cm , and you can contact me at {this.phone}");
        }
    }
}
