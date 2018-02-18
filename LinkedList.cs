using System;
using System.Collections.Generic;

namespace Revision_DS_Algo
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }
        public int Count { get; set; }
        public LinkedList()
        {
            Head = Tail;
            Count = 0;
        }
        public void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if(Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(LinkedListNode<T> node)
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

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while(current.Next != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }

}