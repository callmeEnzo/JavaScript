using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // create a stack
        Stack<string> subject = new Stack<string>();
        subject.Push("Math");
        subject.Push("English");

        // pop the element from top of stack
        Console.WriteLine("Popped element: " + subject.Pop());
    }
}
