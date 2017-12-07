using System;

namespace Revision_DS_Algo
{
    public class LinkedList
    {
        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }
        public int Count { get; set; }
        public LinkedList()
        {
            Head = Tail;
            Count = 0;
        }
        public void AddFirst(LinkedListNode node)
        {
            LinkedListNode temp = Head;
            Head.Next = temp;
            Count++;
            if(Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(LinkedListNode node)
        {
            if(Count == 0)
            {
                Head = node;//Tail is also pointing to this node i.e. the only node.
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }
        
    }

    public class LinkedListNode
    {
        public int value { get; set; }
        public LinkedListNode Next { get; set; }
    }

    
}