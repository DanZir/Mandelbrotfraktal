using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrotfraktal
{
    class Complex
    {

        private double real;
        private double imag;


        public double Real
        {
            get { return real; }
            set { real = value; }
        }


        public double Imag
        {
            get { return imag; }
            set { imag = value; }
        }

        public Complex()
        {
            real = imag = 0.0;
        }

        public Complex(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }

        public Complex(Complex c)
        {
            Real = c.Real;
            Imag = c.Imag;
        }

        public double Argument
        {
            get { return Math.Sqrt(Real * Real + Imag * Imag); }
        }

        public Complex Add(Complex c)
        {
            this.Real += c.Real;
            this.Imag += c.Imag;
            return this;
        }

        public Complex Sub(Complex c)
        {
            this.Real -= c.Real;
            this.Imag -= c.Imag;
            return this;
        }
        public Complex Mul(Complex c)
        {
            double real = this.Real;
            double imag = this.Imag;
            this.Real = real * c.Real - imag * c.Imag;
            this.Imag = real * c.Imag + imag * c.Real;
            return this;
        }
        public static Complex operator + (Complex a, Complex b)
        {
            Complex c = new Complex(a);
            c.Add(b);
            return c;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            Complex c = new Complex(a);
            c.Sub(b);
            return c;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            Complex c = new Complex(a);
            c.Mul(b);
            return c;
        }


    }
}
