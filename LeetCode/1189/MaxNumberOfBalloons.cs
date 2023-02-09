using System;
namespace LeetCode
{
	public class MaxNumberOfBalloonsProblem
	{

		public static void Execute()
		{
			string text = "nlaebolko";

			Console.WriteLine(MaxNumberOfBalloons(text));
		}

		public static int MaxNumberOfBalloons(string text)
		{
			int count = 0;
			string ballon = "ballon";
			Dictionary<char, int> keyValues = new Dictionary<char, int>();

			for(int i = 0; i< ballon.Length; i++)
			{
				if (!keyValues.ContainsKey(ballon[i]))
				{
                    keyValues.Add(ballon[i], text.Count(c => c == ballon[i]));
                }
            }


			return count;
		}

    }
}

