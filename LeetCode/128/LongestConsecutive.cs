using System;
namespace LeetCode
{
	public class LongestConsecutiveProblem
	{
		public static void Execute()
		{
			int[] nums = { 7, -9, 3, -6, 3, 5, 3, 6, -2, -5, 8, 6, -4, -6, -4, -4, 5, -9, 2, 7, 0, 0 };

			Console.WriteLine(LongestConsecutive(nums));
		}

		//O(nlgn);
		public static int LongestConsecutive(int[] nums)
		{
			if (nums.Length == 0) return 0;
			Array.Sort(nums);

			int longestStreak = 1;
			int currentStreak = 1;

			for(int i = 1; i < nums.Length; i++)
			{
				if (nums[i] != nums[i - 1])
				{
					if (nums[i] == nums[i-1] + 1)
					{
						currentStreak++;
					}
					else
					{
						longestStreak = Math.Max(longestStreak, currentStreak);
						currentStreak = 1;
					}
				}
			}

            return longestStreak > currentStreak ? longestStreak : currentStreak;
		}

    }
}

