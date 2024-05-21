using System;

// Premitive data types

class DataType {
	static void Main(string[] args){
		Console.WriteLine("======================================");
		Console.WriteLine("Premitive data types");
		Console.WriteLine("======================================");

		Console.WriteLine("--------Integer (int) Type--------");
		int number = 1;
		Console.WriteLine(number);
		Console.WriteLine(int.MaxValue);
		Console.WriteLine(int.MinValue);

		Console.WriteLine("--------Long Integer (long) Type--------");
		long bigNumber = -900000000L;
		Console.WriteLine(bigNumber);
		Console.WriteLine(long.MaxValue);
		Console.WriteLine(long.MinValue);

		// Double is the default data type for the floating numbers
		Console.WriteLine("--------Double (double) Type--------");
		double doubleNumber = -34.5D;
		Console.WriteLine(doubleNumber);
		Console.WriteLine(double.MaxValue);
		Console.WriteLine(double.MinValue);

		// 'f' suffix is to explicitly tell compiler treat the number you have as a float.
		Console.WriteLine("--------Float (float) Type--------");
		float floatNumber = 5.0001F;
		Console.WriteLine(floatNumber);
		Console.WriteLine(float.MaxValue);
		Console.WriteLine(float.MinValue);

		// 'm' for decimal
		Console.WriteLine("--------Decimal (decimal) Type--------");
		decimal decimalNumber = 5.6666667M;
		Console.WriteLine(decimalNumber);
		Console.WriteLine(decimal.MaxValue);
		Console.WriteLine(decimal.MinValue);
	}
}
