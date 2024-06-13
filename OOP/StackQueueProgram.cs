using System;

public class StackQueueProgram {
    public static void Main() {
        // Stack example
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine(stack.Pop()); // Output: 3
        Console.WriteLine(stack.Peek()); // Output: 2
        Console.WriteLine(stack.IsEmpty()); // Output: False
        Console.WriteLine(stack.Count()); // Output: 2
        

		Console.WriteLine();


        // Queue example
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine(queue.Dequeue()); // Output: 1
        Console.WriteLine(queue.Peek()); // Output: 2
        Console.WriteLine(queue.IsEmpty()); // Output: False
        Console.WriteLine(queue.Count()); // Output: 2
    }
}

