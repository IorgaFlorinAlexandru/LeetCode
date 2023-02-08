using System;
namespace LeetCode
{
	public class FindDisappearedNumbersProblem
	{
		public static void Execute()
		{
			int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };

			var result = FindDisappearedNumbers(nums);

			foreach(var r in result)
			{
				Console.WriteLine(r);
			}
		}

		public static IList<int> FindDisappearedNumbers(int[] nums)
		{
			List<int> result = new List<int>();
            HashSet<int> numbers = nums.ToHashSet();

			for(int i = 1; i <= nums.Length; i++)
			{
				if (!numbers.Contains(i)) result.Add(i);
			}

			return result;
		}

    }
}

