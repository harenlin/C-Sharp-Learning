using System;

class Reference {
	static void print_arr(ref int[] arr){
		foreach (int num in arr) Console.Write(num + " ");
		Console.WriteLine("");
	}

	static void sort_arr(ref int[] arr){
		System.Array.Sort(arr);
	}

	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Reference Parameter");
		Console.WriteLine("======================================");

		int[] nums = { 5, 4, 2, 3, 1 };
		Console.WriteLine("Before sorting: ");
		print_arr(ref nums);
		Console.WriteLine("After sorting: ");
		sort_arr(ref nums);
		print_arr(ref nums);
	}
}
