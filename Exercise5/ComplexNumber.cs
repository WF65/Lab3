using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class ComplexNumber
    {
        protected int real;
        protected int imaginary;
        public int Real {
            get { return this.real; }
            set { this.real = value; } 
        }
        public int Imaginary {
            get { return this.imaginary; }
            set { this.imaginary = value; } 
        }

        public void SetReal(int real)
        {
            this.Real = real;
        }

        public int GetReal()
        {
            return this.Real;
        }

        public void SetImaginary(int imaginary)
        {
            this.Imaginary = imaginary;
        }

        public int GetImaginary()
        {
            return this.Imaginary;
        }

        public ComplexNumber()
        {
            this.Real = 0;
            this.Imaginary = 0;
        }

        public ComplexNumber(int real, int imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public new string ToString()
        {
            return ("(" + this.Real +"," + this.Imaginary +")");
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(this.Real * this.Real + this.Imaginary * this.Imaginary);
        }

        public void Add(ComplexNumber complexNumber)
        {
            this.Real = this.Real + complexNumber.Real;
            this.Imaginary = this.Imaginary + complexNumber.Imaginary;

        }


    }
}
