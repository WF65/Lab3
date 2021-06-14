using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Door
    {
        protected string color;
        public Door()
        {
            color = "Brown";
        }
        public Door(String color)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        
        public void showData()
        {
            Console.WriteLine($"I am a door, my color is {color}");
        }

    }
}
