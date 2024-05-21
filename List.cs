using System;
using System.Collections.Generic;

class List {
	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("List");
		Console.WriteLine("======================================");

		List<int> listNumbers = new List<int>();

		Console.WriteLine("Please enter 5 numbers to your list.");
		for(int i = 0; i < 5; i++){
			Console.Write("type in number {0}: ", i + 1);
			listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
		}

		Console.Write("Current List: ");
		foreach (int num in listNumbers) Console.Write(num + " ");
		Console.WriteLine("");

		Console.WriteLine("Please remove 1 number from your list.");
		while( true ){
			Console.Write("I want to delete the number at the index: ");
			int idx = Convert.ToInt32(Console.ReadLine());
			if( idx >= listNumbers.Count ){
				Console.WriteLine("The index is out of range! Please try again!");
			} else {
				listNumbers.RemoveAt(idx);
				break;
			}
		}
		
		Console.Write("List After Deletion: ");
		foreach (int num in listNumbers) Console.Write(num + " ");
		Console.WriteLine("");

	}
}
