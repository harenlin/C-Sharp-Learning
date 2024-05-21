using System;

class HelloWorld {
	static void Main(string[] args){
		Console.WriteLine("==========================================================\nHello World!");

		// Premitive types
		int number = 1;
		// Double is the default data type for the floating numbers
		// 'f' suffix is to explicitly tell compiler treat the number you have as a float.
		// 'm' 
		const float pi = 3.1415926f;
        decimal dec_num = 1.2m;
		Console.WriteLine(pi);
		Console.WriteLine(dec_num);
		Console.WriteLine("Min number of byte: {0}, Max number of byte: {1}", byte.MinValue, byte.MaxValue);

		// Type conversion
		string num_str = "15";
		int n1 = int.Parse(num_str);
        int n2 = Convert.ToInt32(num_str);
		// Convert:
		// ToByte(), ToInt16(), ToInt32(), ToInt64()
        Console.WriteLine("Converted result: n1 = {0}, n2 = {1}.", n1, n2);

		// Array
		// Declaring an array of integers
        int[] numbers_declare; 
		// Initializing an array of integers with a length of 5
        int[] numbers_init = new int[5]; 
		// Initializing and assigning values to an array of integers
		int[] numbers = { 1, 2, 3, 4, 5 }; 
		Console.WriteLine(numbers);
		// Iterating an array - (1)
        foreach (int num in numbers) {
		    Console.WriteLine(num);
		}
		// Iterating an array - (2)
		for (int i = 0; i < numbers.Length; i++) {
			Console.WriteLine(numbers[i]);
		}
		
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
	}
}
