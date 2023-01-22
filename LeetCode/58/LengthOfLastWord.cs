using System;
namespace LeetCode
{
	public class LengthOfLastWordProblem
	{
		public static void Execute()
		{
			string s = "   fly me   to   the moon  ";

			var result = LengthOfLastWord(s);

			Console.WriteLine(result);
		}

		public static int LengthOfLastWord(string s)
		{
			int count = 0;
			int lastWord = 0;

			for(int i = 0; i < s.Length; i++)
			{
				if (s[i] == ' ')
				{
					lastWord = count != 0 ? count : lastWord;
					count = 0;
				}
				else count++;
			}

			return count != 0 ? count : lastWord;

		}

    }
}

