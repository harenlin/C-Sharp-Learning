using System;

class Array {
	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Array");
		Console.WriteLine("======================================");

		// Array
		// Declaring an array of integers
		int[] numbers_declare; 
		// Initializing an array of integers with a length of 5
		int[] numbers_init = new int[5]; 
		// Initializing and assigning values to an array of integers
		int[] numbers = { 1, 2, 3, 4, 5 };
		Console.WriteLine("--------Array Traversal: ");
		Console.WriteLine(numbers);
		// Iterating an array - (1)
		foreach (int num in numbers) {
			Console.Write(num + " ");
		} Console.WriteLine("");
		// Iterating an array - (2)
		for (int i = 0; i < numbers.Length; i++) {
			Console.Write(numbers[i] + " ");
		} Console.WriteLine("");

		// Array Sorting
		Console.WriteLine("--------Array Sort: ");
		int[] arr = {5,2,9,7,3,5,1,2,0};

		Console.WriteLine("Before Sorting: ");
		foreach (int num in arr) Console.Write(num + " ");
		Console.WriteLine("");

		Console.WriteLine("After Sorting [ASC]: ");
		System.Array.Sort(arr);
		foreach (int num in arr) Console.Write(num + " ");
		Console.WriteLine("");

		Console.WriteLine("After Sorting [DESC]: ");
        System.Array.Reverse(arr);
		foreach (int num in arr) Console.Write(num + " ");
		Console.WriteLine("");

		// Array.IndexOf(array_name, number_to_search, left_index_included, right_index_excluded)
		Console.WriteLine("Enter a number you want to search: ");
		int numToSearch = Convert.ToInt32(Console.ReadLine());
		int positionIdx = System.Array.IndexOf(arr, numToSearch);
		if( positionIdx > -1 ){
			Console.WriteLine("Number is found! At the index {0}.", positionIdx);
		} else {
			Console.WriteLine("Number is not found!");
		}
		
		Console.WriteLine("Enter a number you want to search (for the left-half array): ");
		int numToSearch2 = Convert.ToInt32(Console.ReadLine());
		int positionIdx2 = System.Array.IndexOf(arr, numToSearch2, 0, arr.Length / 2);
		if( positionIdx2 > -1 ){
			Console.WriteLine("Number is found! At the index {0}.", positionIdx2);
		} else {
			Console.WriteLine("Number is not found!");
		}

		/*
		// Declaration of a 2D array
		int[,] matrix = new int[3, 3]; 
		// Assigning values to other elements of the matrix
		matrix[0, 0] = 1;
		matrix[0, 1] = 2;
		matrix[0, 2] = 3;
		matrix[1, 0] = 1;
		matrix[1, 1] = 2;
		matrix[1, 2] = 3;
		matrix[2, 0] = 1;
		matrix[2, 1] = 2;
		matrix[2, 2] = 3;
		for (int i = 0; i < matrix.GetLength(0); i++) {
			for (int j = 0; j < matrix.GetLength(1); j++) {
				Console.Write(matrix[i, j] + " ");
			} Console.WriteLine();
		}
		*/
	}
}
