using System;

namespace Revision_DS_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node(){value = 1 };

            Node second = new Node(){value = 2};
            first.Next = second;

            Node three = new Node() { value = 3};
            second.Next = three;

            PrintList(first);
        }

        private static void PrintList(Node node)
        {
            while(node != null)
            {
                Console.WriteLine(node.value);
                node = node.Next;
            }
        }
    }


}
