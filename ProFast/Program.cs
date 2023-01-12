namespace ProFast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 688;
            double num2 = num1;
            byte num3 = (byte)num1;
            
            if (int.TryParse(Console.ReadLine(),out int b))
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("it is not a number!!");
            }

            ImutableClass imutable = new ImutableClass("Syuzi",1948);
        }
    }
}