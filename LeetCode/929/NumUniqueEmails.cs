using System;
using System.Text;

namespace LeetCode
{
	public class NumUniqueEmailsProblem
	{
		public static void Execute()
		{
			string[] s = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };

			int result = NumUniqueEmails(s);

			Console.WriteLine(result);

		}

		public static int NumUniqueEmails(string[] s)
		{
			int output = 0;
			StringBuilder sb = new StringBuilder();
			HashSet<string> strings = new HashSet<string>();
			for(int i = 0; i<s.Length; i++)
			{
				for(int j = 0; j < s[i].Length; j++)
				{
					if (!(s[i][j] == '.'))
					{
						sb.Append(s[i][j]);
					}
					if (s[i][j] == '+')
					{

					}
				}

				if (!strings.Contains(sb.ToString()))
				{
					strings.Add(sb.ToString());
					output++;
				}

				sb.Clear();
			}

			return output;
		}

    }
}

