using System;

namespace StackAndQueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to Stack And Queue");
            StackUsingLinkedList linkedListStack = new StackUsingLinkedList();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            Console.WriteLine();
            linkedListStack.Peek();
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
            linkedListStack.Display();
        }
    }
}
