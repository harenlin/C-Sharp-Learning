using System;

class ParamsRefOutModifiers
{
	public static int ArraySum(params int[] nums){
		int res = 0;
		for(int idx = 0; idx < nums.Length; idx++){
			res += nums[idx];
		}
		return res;
	}

	// [CAUTION] A params parameter must be the last parameter in a formal parameter list
	public static void ArraySum(ref int res, params int[] nums) {
		res = 0;
		for(int idx = 0; idx < nums.Length; idx++){
			res += nums[idx];
		}
	}

	// [CAUTION] A params parameter must be the last parameter in a formal parameter list
	public static void topNArraySum(out int sum, int n, params int[] nums) {
		sum = 0;
		for(int idx = 0; idx < Math.Min(n, nums.Length); idx++){
			sum += nums[idx];
		}
	}

	static void Main(string[] args)
    {
		Console.WriteLine("======================================");
		Console.WriteLine("Params Modifier");
		Console.WriteLine("======================================");

		Console.WriteLine(ArraySum(new int[]{1, 2, 3, 4, 5}));
		Console.WriteLine(ArraySum(1, 2, 3, 4, 5));

		
		Console.WriteLine("\n======================================");
		Console.WriteLine("Ref Modifier");
		Console.WriteLine("======================================");

		int res = 0;
		ArraySum(ref res, new int[]{1, 2, 3, 4, 5});
		Console.WriteLine(res);
		ArraySum(ref res, 1, 2, 3, 4, 5);
		Console.WriteLine(res);
		
		Console.WriteLine("\n======================================");
		Console.WriteLine("Out Modifier");
		Console.WriteLine("======================================");

		int sum = 0;;
		topNArraySum(out sum, 5, new int[]{1, 2, 3, 4, 5});
		Console.WriteLine(sum);
		topNArraySum(out sum, 5, 1, 2, 3, 4, 5);
		Console.WriteLine(sum);
    }
}

