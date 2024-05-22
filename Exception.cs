using System;

class Exception {
	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Try-Catch Exception");
		Console.WriteLine("======================================");

		while(true){
			Console.Write("Enter a number: ");
			try {
				int num = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Hello World!");
				break;
			} catch (System.OverflowException e_over) {
				// Console.WriteLine("Number Overflowed!");
				Console.WriteLine($"Error: {e_over.Message}");
			} catch (System.FormatException e_format) {
				// Console.WriteLine("Invalid Format!");
				Console.WriteLine($"Error: {e_format.Message}");
			} catch (System.Exception e) {
				// Console.WriteLine("Invalid Input!");
				Console.WriteLine($"Error: {e.Message}");
			}
		}
	}
}
