
using DataStructures.LinkedLists.DoblyLinkedList;
using DataStructures.LinkedLists.SinglyLinkedList;
using DataStructures.Stacks.LinkedListeBasedStack;
namespace DataStructures
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            Console.WriteLine(list.ToString());

            LinkedStack<int> stack = new LinkedStack<int>(list);

            stack.Push(11);
            stack.Push(12);
            stack.Push(13);

            Console.WriteLine(stack.Size());

            //ISinglyLinkedList<int> list = new SinglyLinkedList<int>();

            //list.AddLast(1);
            //list.AddFirst(1);
            //list.AddLast(2);
            //Console.WriteLine(list.ToString());
            //list.RemoveFirst();
            //Console.WriteLine(list.ToString());
            //list.AddFirst(3);
            //Console.WriteLine(list.ToString());
        }
    }

}