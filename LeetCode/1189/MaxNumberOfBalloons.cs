using System;
namespace LeetCode
{
	public class MaxNumberOfBalloonsProblem
	{

		public static void Execute()
		{
			string text = "b";

			Console.WriteLine(MaxNumberOfBalloons(text));
		}

		public static int MaxNumberOfBalloons(string text)
		{
			int count = 0;
			string ballon = "balon";
			Dictionary<char, int> keyValues = new Dictionary<char, int>();

			for(int i = 0; i< ballon.Length; i++)
			{
				if (!keyValues.ContainsKey(ballon[i]))
				{
                    keyValues.Add(ballon[i], text.Count(c => c == ballon[i]));
                }
            }

            keyValues['l'] /= 2;
			keyValues['o'] /= 2;

            return keyValues.Min(x => x.Value);
		}

    }
}

