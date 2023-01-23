using System;
namespace LeetCode
{
	public class ContainsNearbyDuplicateProblem
	{
		public static void Execute()
		{
			int[] nums = { 1, 2, 3, 1, 2, 3 };
			int k = 2;

			var result = ContainsNearbyDuplicate(nums, k);
			Console.WriteLine(result);
		}

		public static bool ContainsNearbyDuplicate(int[] nums,int k)
		{
			HashSet<int> numbers = new HashSet<int>();
			for(int i = 0; i<nums.Length; i++)
			{
				if (numbers.Contains(nums[i]))
				{
					var indexes = nums.Select((value, index) => new { value, index })
						.Where(x => x.value == nums[i] && x.index != i)
						.Select(x => x.index)
						.ToArray();
					for(int j = 0; j < indexes.Length; j++)
					{
                        if (Math.Abs(i - indexes[j]) <= k) return true;
					}

				}
				else
					numbers.Add(nums[i]);
			}

			return false;
		}

    }
}

