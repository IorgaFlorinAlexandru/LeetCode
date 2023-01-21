using System;
namespace LeetCode
{
	public class ContainsDuplicateProblem
	{
		public static void Execute()
		{
			int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

			var result = ContainsDuplicate(nums);

			Console.WriteLine(result);
		}

        public static bool ContainsDuplicate(int[] nums)
        {
			HashSet<int> hashMap = new HashSet<int>();

			for(int i=0; i<nums.Length; i++)
			{
				if (hashMap.Contains(nums[i])) return true;

				hashMap.Add(nums[i]);
			}

			return false;
        }
    }
}

