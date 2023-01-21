namespace DistinctListObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyObject my = new MyObject();
            MyObject my1 = new MyObject();
            MyObject my2 = new MyObject();
            my.Id = 1;
            my.Name = "AA";
         
            my1.Id = 1;
            my1.Name = "AA";

            my2.Id = 1;
            my2.Name = "A";

            List<MyObject> myList = new List<MyObject>();
            myList.Add(my);
            myList.Add(my1);
            myList.Add(my2);

            List<MyObject> distinctList = myList.Distinct(new MyObjectComparer()).ToList();
        }
    }
}
class MyObject
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class MyObjectComparer : IEqualityComparer<MyObject>
{
    public bool Equals(MyObject x, MyObject y)
    {
        return x.Id == y.Id && x.Name == y.Name;
    }

    public int GetHashCode(MyObject obj)
    {
        return obj.Id.GetHashCode();
    }
}