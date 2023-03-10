
namespace EnumFlags
{

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (MultiHue)val);
        }

    }
    [Flags]
    enum MultiHue : short
    {
        None = 0,
        Black = 1,
        Red = 2,
        Green = 4,
        Blue = 8
    };
}