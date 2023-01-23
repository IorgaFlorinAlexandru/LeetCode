using System;
using System.Text;

namespace LeetCode
{
	public class LongestCommonPrefixProblem
	{
		public static void Execute()
		{
			string[] strs = { "flower", "flow", "flight" };
			string[] aa = { "aa", "aa" };
			string[] strs2 = { "racecar", "car" };

			var result = LongestCommonPrefix(strs);

			Console.WriteLine(result);

		}

		public static string LongestCommonPrefix(string[] strs)
		{
			StringBuilder sb = new StringBuilder();

			string s = strs[0];
			for(int i = 1; i < strs.Length; i++)
			{
				for(int j = 0; j < s.Length; j++)
				{
					if (j < strs[i].Length)
						if (strs[i][j] == s[j]) sb.Append(s[j]);
						else break;
                }
				s = sb.ToString();
				sb.Clear();
			}

			return s;
		}

    }
}

