using System;
using System.Collections.Generic; 

class LambdaExpressionProgram {
    static void Main(string[] args){
        // args => expression
        // () => ...
        // (x) => ...
        // (x, y, z) => ...
        
        Func<int, int> square = (number) => number * number;
        Console.WriteLine(square(5));

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

		// public System.Collections.Generic.List<T> FindAll (Predicate<T> match);
		// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.findall?view=net-8.0
        var oddNums = list.FindAll(num => num % 2 == 1);
        var evenNums = list.FindAll(num => num % 2 == 0);

        Console.WriteLine("Odd Nums: ");
        foreach(int oddNum in oddNums) {
            Console.Write(oddNum);
            Console.Write(" ");
        }
        Console.WriteLine(); 

        Console.WriteLine("Even Nums: ");
        foreach(int evenNum in evenNums) {
            Console.Write(evenNum);
            Console.Write(" ");
        }
		Console.WriteLine(); 
    }
}

