namespace LeetCode
{
	public class CanPlaceFlowersProblems
	{
		public static void Execute()
		{
			int[] flowerbed = { 1, 0, 0, 0 };

			Console.WriteLine(CanPlaceFlowers(flowerbed, 1));

		}

		public static bool CanPlaceFlowers(int[] flowerbed, int n)
		{
			int count = 0;

			int index = 1;

			if (flowerbed.Length > 1)
			{
				if (flowerbed[0] == 0 && flowerbed[1] == 0)
				{
					flowerbed[0] = 1;
					count++;
					index = 2;
				}
			}
			else
				count = flowerbed[0] == 0 ? 1 : 0;

			while(index < flowerbed.Length - 1)
			{
                if (flowerbed[index] == 0 && flowerbed[index - 1] == 0 && flowerbed[index + 1] == 0)
                {
					flowerbed[index] = 1;
                    count++;
                    index++;
                }

                index++;
			}

			if(flowerbed.Length > 1 && index < flowerbed.Length)
			{

				if (flowerbed[index] == 0 && flowerbed[index-1] == 0 && flowerbed.Length > 1)
				{
					count++;
				}
			}


			return count >= n;
		}


    }
}

