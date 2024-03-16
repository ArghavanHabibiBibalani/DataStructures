
using DataStructures.LinkedLists;
namespace DataStructures
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(1);
            list.AddLast(2);
            Console.WriteLine(list.ToString());
           
        }
    }

}