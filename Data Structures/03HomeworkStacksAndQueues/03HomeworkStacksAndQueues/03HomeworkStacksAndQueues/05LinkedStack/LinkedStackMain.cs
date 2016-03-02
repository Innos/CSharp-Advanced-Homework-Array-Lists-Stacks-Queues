using System;

namespace _05LinkedStack
{
    public class LinkedStackMain
    {
        public static void Main(string[] args)
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(string.Join(" ",stack));

            Console.WriteLine(stack.Pop());

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
