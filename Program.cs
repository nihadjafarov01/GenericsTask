namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>(5,1,2,3,4);
            //list.Clear();
            //Console.WriteLine(list.Exist(3)); 
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.IndexOf(1));
            list.IndexOf(3);
            //Console.WriteLine(list.IndexOf(1));
            list[0] = 5;
            list.GetAll();
        }
    }
}