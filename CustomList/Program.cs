//namespace CustomList
//{
//    class MyList<T> : List<T>
//    {

//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            MyList<int> myList = new MyList<int>();
//            myList.Add(1);
//            myList.Add(2);
//            myList.Add(3);

//            foreach (int item in myList)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("Hello, World!");
//        }
//    }
//}
//using System.Collections;
//using System.Threading.Channels;

//namespace CustomList
//{
//    class MyList<T> : IEnumerable<T>
//    {
//        private T[] items = new T[10];
//        private int count = 0;

//        public void Add(T item)
//        {
//            items[count++] = item;
//        }

//        public IEnumerator<T> GetEnumerator()
//        {
//            for (int i = 0; i < count; i++)
//            {
//                yield return items[i];
//            }
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            MyList<int> myList = new MyList<int>();
//            myList.Add(1);
//            myList.Add(9);
//            myList.Add('A');

//            foreach (int item in myList)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}

