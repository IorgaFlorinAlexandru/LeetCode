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
				var sts = s[i].Split('@');

				for(int j = 0; j < sts[0].Length; j++)
				{
					if (!(sts[0][j] == '.' || sts[0][j] == '+'))
					{
						sb.Append(sts[0][j]);
					}
					if (sts[0][j] == '+')
					{
						j = sts[0].Length;
					}
				}

				sb.Append('@' + sts[1]);

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

