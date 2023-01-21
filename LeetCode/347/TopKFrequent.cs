namespace LeetCode
{
	public class TopKFrequentProblem
	{
		public static void Execute()
		{
			int[] nums = { 1, 1, 1, 2, 2, 3 };
			int k = 2;

			var results = TopKFrequent(nums, k);

			foreach(var result in results)
			{
                Console.WriteLine(result);
            }
		}

		public static int[] TopKFrequent(int[] nums,int k)
		{
			Dictionary<int, int> keyValues = new Dictionary<int, int>();

			for(int i = 0; i < nums.Length; i++)
			{
				if (keyValues.ContainsKey(nums[i]))
				{
					keyValues[nums[i]]++;
				}
				else
					keyValues.Add(nums[i], 1);
			}

			return keyValues.OrderByDescending(x => x.Value)
				.Select(x => x.Key)
				.Take(k)
				.ToArray();
		}

    }
}

