using System;
namespace LeetCode
{
	public class ReplaceElementsProblem
	{
		public static void Execute()
		{
			int[] nums = { 17, 18, 5, 4, 6, 1 };

			var results = ReplaceElements(nums);

			foreach (var item in results)
				Console.WriteLine(item);
		}

		public static int[] ReplaceElementsOn2(int[] nums)
		{
			for(int i = 0; i < nums.Length - 1; i++)
			{
				int largest = -1;
				for(int j = i+1; j < nums.Length; j++)
				{
					largest = largest < nums[j] ? nums[j] : largest;
				}
				nums[i] = largest;
			}

			nums[nums.Length - 1] = -1;

			return nums;
		}

		//O(n)
		public static int[] ReplaceElements(int[] nums)
		{
			int initialMax = -1;
			for(int i = nums.Length - 1; i >= 0; i--)
			{
				var lastMax = initialMax;
				initialMax = initialMax < nums[i] ? nums[i] : initialMax;
				nums[i] = lastMax;
			}

			return nums;
		}

    }
}

