namespace LeetCode
{
	public class CanPlaceFlowersProblems
	{
		public static void Execute()
		{
			int[] flowerbed = { 1, 0, 0, 0, 0, 1 };

			Console.WriteLine(CanPlaceFlowers(flowerbed, 2));

		}

		public static bool CanPlaceFlowers(int[] flowerbed, int n)
		{
			int count = 0;

			for(int i = 0; i < flowerbed.Length - 1; i++)
			{

				if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
				{
					count++;
					i++;
				}
			}

			return count == n;
		}


    }
}

