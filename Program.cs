using System;

namespace Revision_DS_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node() { value = 1 };

            Node second = new Node() { value = 2 };
            first.Next = second;

            Node three = new Node() { value = 3 };
            second.Next = three;

            PrintList(first);

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(new LinkedListNode<int>(1));
            linkedList.AddLast(new LinkedListNode<int>(2));
            linkedList.AddLast(new LinkedListNode<int>(3));
            try
            {
                var linkList = linkedList.GetEnumerator();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
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
