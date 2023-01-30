namespace LeetCode
{
	public class ProductExceptSelfProblem
	{
		public static void Execute()
		{
			int[] nums = { 1, 2, 3, 4 };
			int[] nums2 = { -1, 1, 0, -3, 3 };

			var results = ProductExceptSelf(nums2);

			foreach(var result in results)
			{
				Console.WriteLine(result);
			}
		}

		public static int[] ProductExceptSelf(int[] nums)
		{
			int sum = 1;
			for(int i = 0; i < nums.Length; i++)
			{
				sum *= nums[i];
			}

			for(int i = 0; i < nums.Length; i++)
			{
				nums[i] = sum / nums[i];
			}

			return nums;
		}

    }
}

