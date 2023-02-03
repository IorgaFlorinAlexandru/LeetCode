namespace LeetCode
{
	public class ProductExceptSelfProblem
	{
		public static void Execute()
		{
			int[] nums = { 1, 2, 3, 4 };
			int[] nums2 = { -1, 1, 0, -3, 1 };

			var results = ProductExceptSelf(nums);

			foreach(var result in results)
			{
				Console.WriteLine(result);
			}
		}

		public static int[] ProductExceptSelf(int[] nums)
		{
			int sum = 1;
			bool hasZero = false;
			for(int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == 0)
				{
					if (hasZero)
					{
						sum = 0;
					}
					else
					{
						hasZero = true;
					}
				}
				else sum *= nums[i];
			}

			for(int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != 0)
				{
					if (hasZero) nums[i] = 0;
					else nums[i] = sum / nums[i];

                }
				else nums[i] = sum;
			}

			return nums;
		}

    }
}

