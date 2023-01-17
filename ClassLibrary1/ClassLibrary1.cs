namespace ClassLibrary1
{
    public class A
    {
        private protected int myValue = 88;
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine(myValue);
        }

    }
}