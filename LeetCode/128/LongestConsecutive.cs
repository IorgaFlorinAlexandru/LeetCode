using System;
namespace LeetCode
{
	public class LongestConsecutiveProblem
	{
		public static void Execute()
		{
			int[] nums = { 1, 2, 0, 1 };

			Console.WriteLine(LongestConsecutive(nums));
		}

		public static int LongestConsecutive(int[] nums)
		{
			if (nums.Length == 0) return 0;
			int k = 1;
			var orderedNums = nums.OrderBy(x => x);

			int index = 1;
			for(int i = 0; i<orderedNums.Count() - 1; i++)
			{
				if (orderedNums.ElementAt(i) == orderedNums.ElementAt(i+1) - 1)
				{
					index++;
				}
				else
				{
					if (k < index)
					{
						k = index;
						index = 1;
					}
				}
			}

            if (k < index)
            {
                k = index;
            }

            return k;
		}

    }
}

