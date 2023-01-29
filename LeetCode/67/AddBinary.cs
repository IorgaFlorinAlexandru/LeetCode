using System;
using System.Text;

namespace LeetCode
{
	public class AddBinaryProblem
	{
		public static void Execute()
		{
			string a = "1011";
			string b = "1111";

			var result = AddBinary(a, b);

			Console.WriteLine(result);
		}

        public static string AddBinary(string a, string b)
        {
			bool carry = false;
			int indexA = a.Length - 1;
			int indexB = b.Length - 1;
			StringBuilder sb = new StringBuilder();

			while (indexA >= 0 || indexB >= 0 || carry)
			{
				int v1 = 0, v2 = 0;
				if (indexA >= 0)
					v1 = a[indexA] - '0';
				if (indexB >= 0)
					v2 = b[indexB] - '0';

				int answer = v1 + v2;
				if (carry) answer += 1;
				carry = answer > 1;
				if (carry)
					answer -= 2;
				sb.Append(answer);

				indexA--;
				indexB--;
			}


			return Reverse(sb.ToString());
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

