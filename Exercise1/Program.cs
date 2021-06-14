using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.getSize();
            Calculate(rec);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Circle cir = new Circle();
            cir.getSize();
            Calculate(cir);
        }

        public static void Calculate(Shape1 S)
        {

            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());

        }
    }
}
