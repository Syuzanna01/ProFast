using System.Collections;
using System.Threading.Channels;

namespace CustomList
{
    class MyList<T> : IEnumerable
    {
        private List<T> items = new List<T>();
        private int count = 0;

        public void Add(T item)
        {
            items.Add(item);
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }

        public T Get(int index)
        {
            return items[index];
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>() { 1, 8, 6, 11 };
            myList.Add(1);
            myList.Add(9);
            myList.Add('A');

            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

