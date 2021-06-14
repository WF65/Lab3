using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Circle: Shape1
    {
        public void getSize()
        {
            Console.WriteLine("Enter circle radius:");
            R = Convert.ToSingle(Console.ReadLine());
        }

        public override float Area()
        {
            return Convert.ToSingle(Math.PI * R * R);
        }

        public override float Circumference()
        {
            return Convert.ToSingle(2 * Math.PI * R);
        }
    }
}
