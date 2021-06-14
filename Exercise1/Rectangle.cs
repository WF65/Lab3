using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle: Shape1
    {
        public void getSize()
        {
            Console.WriteLine("Enter rectangle length:");
            L = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter rectangle breadth:");
            B = Convert.ToSingle(Console.ReadLine());
        }
        public override float Area()
        {
            return L*B;
        }

        public override float Circumference()
        {
            return 2*(L+B);
        }

    }
}
