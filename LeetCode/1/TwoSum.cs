using System;
namespace LeetCode
{
	public class TwoSumProblem 
	{
        public static void Execute()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] results = TwoSum(nums, target);

            foreach(var result in results)
            {
                Console.WriteLine(result);
            }
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            HashSet<int> hashMap = new HashSet<int>();

            for(int i = 0; i<nums.Length; i++)
            {
                int diff = target - nums[i];
                if (hashMap.Contains(diff))
                {
                    return new int[] { Array.IndexOf(nums,diff), i };
                }
                else
                    hashMap.Add(nums[i]);
            }

            return  Array.Empty<int>();
        }
    }
}

