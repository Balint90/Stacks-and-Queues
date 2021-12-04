using System;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stacks
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

            //Queues
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            int queueItem = queue.Dequeue();
            Console.WriteLine("DeQueueed item: {0}", queueItem);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());

            while (queue.Count > 0)
            {
                Console.WriteLine("DeQueueed item: {0}", queue.Dequeue());
            }

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order order in ReceiveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(order);
            }

            foreach (Order order in ReceiveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(order);
            }

            while (ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
        }

        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10),
            };
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10),
            };
            return orders;
        }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuality { get; set; }
        public Order(int id, int orderQuantity)
        {
            OrderId = id;
            OrderQuality = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }
}
