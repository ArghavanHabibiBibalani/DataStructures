using DataStructures.Queue.ArrayBasedQueue;
namespace DataStructures
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ArrayQueue<int> queue = new ArrayQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine(queue.Size());
            Console.WriteLine(queue.First());
            queue.Dequeue();
            Console.WriteLine(queue.Size());
            Console.WriteLine(queue.First());

        }
    }

}