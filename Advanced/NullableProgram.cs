using System;

class NullableProgram {
	static void Main(string[] args) {
		// Nullable Type Definition - 1
		Nullable<DateTime> date0 = null;
		
		Console.WriteLine(date0.GetValueOrDefault());
		Console.WriteLine(date0.HasValue);
		Console.WriteLine(date0.Value);
		
		// Nullable Type Definition - 2
		DateTime? date1 = null;

		// ?? Null Coalescing Operator
		DateTime date2 = date0 ?? DateTime.Today;

		DateTime date3 = (date0 != null) ? date0.GetValueOrDefault() : DateTime.Today;

		DateTime date4 = new DateTime(2024, 6, 6);

		Console.WriteLine(date0);
		Console.WriteLine(date1);
		Console.WriteLine(date2);
		Console.WriteLine(date3);
		Console.WriteLine(date4);
	}
}
