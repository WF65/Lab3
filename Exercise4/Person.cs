using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Person
    {

        public int Age { get; set; }

        public Person()
        {
            Age = 20;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
            
    }
}
