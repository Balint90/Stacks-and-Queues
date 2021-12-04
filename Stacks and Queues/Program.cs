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
            int item = stack.Pop();
            Console.WriteLine("Popped item: {0}", item);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine("Popped item: {0}", stack.Pop());
            }

            //reversing an int array
            Stack<int> myStack = new Stack<int>();
            int[] numbers=new int[] {8,2,3,4,7,6,2};

            Console.WriteLine("The numbers in the array are: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
                myStack.Push(number);
            }
            Console.WriteLine();
            Console.WriteLine("Reversed numbers: ");
            while (myStack.Count > 0)
            {
                Console.Write("{0} ", myStack.Pop());
            }

        }
    }
}
