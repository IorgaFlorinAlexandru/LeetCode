namespace LeetCode
{
	public class ProductExceptSelfProblem
	{
		public static void Execute()
		{
			int[] nums = { 1, 2, 3, 4 };

			var results = ProductExceptSelf(nums);

			foreach(var result in results)
			{
				Console.WriteLine(result);
			}
		}

		public static int[] ProductExceptSelf(int[] nums)
		{
			Dictionary<int, int> keyValues = new Dictionary<int, int>();
			for(int i = 0; i < nums.Length; i++)
			{
				keyValues.Add(nums[i], 1);
			}

            for (int i = 0; i < nums.Length; i++)
            {
                
            }
			return keyValues.Select(x => x.Value).ToArray();
		}

    }
}

