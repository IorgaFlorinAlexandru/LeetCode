using System;
namespace LeetCode
{
	public class ValidAnagramProblem
	{
        public static void Execute()
        {
            string s = "ab";
            string t = "ab";

            var result = IsAnagram(s, t);

            Console.WriteLine(result);

        }
        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> keyValuesS = new Dictionary<char, int>();
            Dictionary<char, int> keyValuesT = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (keyValuesS.ContainsKey(s[i]))
                {
                    keyValuesS[s[i]]++;
                }
                else
                {
                    keyValuesS.Add(s[i], 1);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (keyValuesT.ContainsKey(t[i]))
                {
                    keyValuesT[t[i]]++;
                }
                else
                {
                    keyValuesT.Add(t[i], 1);
                }
            }

            return keyValuesS.Count == keyValuesT.Count && !keyValuesS.Except(keyValuesT).Any();
        }

        public static bool IsAnagramSort(string s, string t)
        {


            return s == t;
        }
    }
}

