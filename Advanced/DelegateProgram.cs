
// https://www.youtube.com/watch?v=qeX96Dzx1fw

using System;

class DelegateProgram {
	public delegate int Operation(int x, int y);
	// public Operation operationChain;

	static int Add(int x, int y) {
		Console.WriteLine("Result After Add: {0}", x + y);
		return x + y;
	}

	static int Multiply(int x, int y) {
		Console.WriteLine("Result After Multiplication: {0}", x * y);
		return x * y;
	}

	static void DoOperation(int x, int y, Operation op) {
		var res = op(x, y);
		Console.WriteLine("op(x, y): " + res);
	}

	static void Main(string[] args){
		// Delegate (like function pointer / reference in C/C++)
		DoOperation(5, 3, Add);
		DoOperation(5, 3, Multiply);
		Console.WriteLine();
		
		// Using Func<int, int, int> to create a lambda expression and assigning it to the custom delegate
        Func<int, int, int> operFunc = (x, y) => 2 * x * y;	
		Operation oper = new Operation(operFunc);
		// Operation oper = new Operation((x, y) => 2 * x * y);
		oper(5, 3); // this line will not print anything out, just run the lambda expression above only
		DoOperation(5, 3, oper);
		Console.WriteLine();
		
		// Delegate Chain
		Operation operationChain = null;
		operationChain += Add;
		operationChain += Multiply;	
		operationChain(5, 3);
		Console.WriteLine();

		// Using Action<int, int> to create a chain of operations "without return value"
        Action<int, int> actionChain = null;
        actionChain += (x, y) => Console.WriteLine("Action - Result After Add: {0}", x + y);
        actionChain += (x, y) => Console.WriteLine("Action - Result After Multiplication: {0}", x * y);
        actionChain(5, 3);
        Console.WriteLine();
	}
}
