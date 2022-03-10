using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Human
    {
        public Human()
        {

        }
        public Human(int age)
        {
            Age = age ;
            Console.WriteLine("Human created");
        }

        public string Name;
        public string Surname;
        public int Age;
        public bool Gender;
    }
}
