using System;
using static System.Console;

namespace Revision_DS_Algo
{
    public class Queue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void Insert(long j)
        {
            if (IsFull())
            {
                WriteLine($"Queue is already full, so can't insert {j}");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                myQueue[rear] = j;
                items++;
            }
        }

        public long Remove()
        {
            long temp = myQueue[front];
            front++;
            items--;
            if(front == maxSize)
            {
                front = 0;
            }
            return temp;
        }

        public long PeekFront()
        {
            return myQueue[front];
        }

        public bool IsEmpty()
        {
            return items == 0;
        }

        private bool IsFull()
        {
            return items == maxSize;
        }

        public void DisplayQueueItems()
        {
            for(int i = 0; i < myQueue.Length; i++)
            {
                WriteLine(myQueue[i]);
            }
        }
    }

}