
using DataStructures.LinkedLists.DoblyLinkedList;
using DataStructures.LinkedLists.SinglyLinkedList;
namespace DataStructures
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();

            list.AddFirst(1);
            list.AddLast(2);
            Console.WriteLine(list.ToString());
            list.RemoveFirst();
            Console.WriteLine(list.ToString());
            list.AddFirst(3);
            Console.WriteLine(list.ToString());
        }
    }

}