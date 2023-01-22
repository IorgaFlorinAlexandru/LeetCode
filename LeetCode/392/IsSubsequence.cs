using System;
namespace LeetCode
{
	public class IsSubsequenceProblem
	{
		public static void Execute()
		{
			string s = "aec";
			string t = "abcde";

			var result = IsSubsequence(s, t);

			Console.WriteLine(result);

        }

		public static bool IsSubsequence(string s, string t)
		{
            int counter = 0;

			for(int i = 0; i<t.Length; i++)
			{
				if(counter < s.Length)
				{
                    if (t[i] == s[counter]) counter++;
                }
			}

			return counter == s.Length;
		}

    }
}

