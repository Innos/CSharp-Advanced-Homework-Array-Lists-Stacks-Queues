namespace _07LinkedQueue
{
    using System;

    public class LinkedQueueMain
    {
        public static void Main()
        {
            var queue = new LinkedQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(string.Join(" ", queue));

            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(string.Join(" ", queue));
        }
    }
}
