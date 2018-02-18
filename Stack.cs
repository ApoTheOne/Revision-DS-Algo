using System;
using static System.Console;
namespace Revision_DS_Algo
{
    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;
        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void Push(string item)
        {
            if (IsFull())
            {
                WriteLine($"Cannot push {item} in the stack as it's full");
            }
            else
            {
                top++;
                stackArray[top] = item;
            }
        }

        private bool IsFull()
        {
            return (maxSize - 1 == top);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                WriteLine("Stack is empty");
                return "nahhhh!";
            }
            else
            {
                int previousTop = top;
                top--;
                return stackArray[previousTop];
            }
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public string Peek()
        {
            return stackArray[top];
        }
    }
}