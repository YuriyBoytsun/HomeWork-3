using System;


namespace HW3._1
{
    class Complex
    {
        public int a, b;
        public Complex(int re, int im)
        {
            this.a = re;
            this.b = im;
        }
       
        

        public string Print()
        {
            string s;
            if (b < 0) s = $"{a} - {-b}i";
            else s = $"{a} + {b}i";
            return s;
        }

       public Complex Sum(Complex z)
        {
            Complex result = new(this.a + z.a, this.b + z.b);

            return result;
        }

        public Complex Sub(Complex z)
        {
            Complex result = new(this.a - z.a, this.b - z.b);

            return result;
        }

        public Complex Mul(Complex z)
        {
            Complex result = new((this.a*z.a) - (this.b*z.b),(this.b*z.a)+(this.a*z.b));

            return result;
        }
    }
}
