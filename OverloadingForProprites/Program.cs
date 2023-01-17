namespace OverloadingForProprites
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber { Real = 1, Imaginary = 2 };
            ComplexNumber c2 = new ComplexNumber { Real = 1, Imaginary = 2 };
            ComplexNumber c3 = new ComplexNumber { Real = 8, Imaginary = 2 };
            bool areEqual = (c1 == c2);
            bool areNotEqual = (c1 == c3);

            Console.WriteLine("c1 == c2 " + areEqual);
            Console.WriteLine("c1 == c3 " + areNotEqual);
        }
    }
}

struct ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
    {
        return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
    }

    public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
    {
        return c1.Real != c2.Real && c1.Imaginary != c2.Imaginary;
    }
}