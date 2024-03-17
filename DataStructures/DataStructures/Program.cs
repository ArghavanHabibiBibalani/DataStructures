
using DataStructures.LinkedLists.DoblyLinkedList;
using DataStructures.LinkedLists.SinglyLinkedList;
using DataStructures.Stacks.LinkedListeBasedStack;
using DataStructures.Stacks.ArrayBasedStack;
using DataStructures.Stacks;
namespace DataStructures
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ArrayStack<int> s = new ArrayStack<int>();

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            Console.WriteLine(s.Size());
            s.Pop();
            Console.WriteLine(s.Size());
        }
    }

}