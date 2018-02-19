using System;
using static System.Console;

namespace Revision_DS_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(4);
            queue.Insert(10);
            queue.Insert(20);
            queue.Insert(30);
            queue.Insert(40);
            queue.Insert(50);
            
            WriteLine($"Peeking into the front element: {queue.PeekFront()}");

            WriteLine("Queue elements: ");
            queue.DisplayQueueItems();
            while(!queue.IsEmpty())
            {
                long item = queue.Remove();
                WriteLine($"Removing {item}");
                WriteLine($"Now the front element is: {queue.PeekFront()}");
            }

            // Stack stack = new Stack(4);
            // stack.Push("a");
            // stack.Push("b");
            // stack.Push("c");
            // stack.Push("d");
            // stack.Push("e");

            // WriteLine($"Peeking into the top element: {stack.Peek()}");

            // WriteLine("Stack elements: ");
            // while(!stack.IsEmpty())
            // {
            //     string item = stack.Pop();
            //     WriteLine($"Popped out {item}");
            // }

            // Node first = new Node() { value = 1 };

            // Node second = new Node() { value = 2 };
            // first.Next = second;

            // Node three = new Node() { value = 3 };
            // second.Next = three;

            // PrintList(first);

            // LinkedList<int> linkedList = new LinkedList<int>();
            // linkedList.AddFirst(new LinkedListNode<int>(1));
            // linkedList.AddLast(new LinkedListNode<int>(2));
            // linkedList.AddLast(new LinkedListNode<int>(3));
            // try
            // {
            //     var linkList = linkedList.GetEnumerator();
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.StackTrace);
            // }
        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.Next;
            }
        }
    }


}
