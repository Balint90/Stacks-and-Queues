using System;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
        }
    }
}
