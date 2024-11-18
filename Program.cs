using System.ComponentModel;
using System.Runtime.CompilerServices;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Rational project ---");
            Rational r1 = new Rational();
            Rational r2 = new Rational(2, 6);
           
            r2.WriteRational3();
            r2.Reduce();
            r2.WriteRational3();


        /*
    public void Reduce(Rational r)
    {
        int gcd = GCD(r.numerator, r.denominator);
        r.numerator /= gcd;
        r.denominator /= gcd;
    }
         */

    }
}
    

