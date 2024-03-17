using DataStructures.Lists.ArrayList;
namespace DataStructures
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();

            list.Add(0, 0);
            list.Add(1, 1);
            list.Add(2, 2);
            Console.WriteLine(list.Size());


        }
    }

}