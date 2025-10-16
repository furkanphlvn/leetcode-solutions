public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        for (int i = 0; i < flowerbed.Length; i++)
        {
            // Check if the current spot is empty
            if (flowerbed[i] == 0)
            {
                bool emptyL = (i == 0) || (flowerbed[i - 1] == 0);
                // i=0 or flowerbed[i-1]==0

                bool emptyR = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);
                // i=flowerbed.Length-1 or flowerbed[i+1]==0

                // If both sides are empty, we can plant a flower here
                if (emptyL && emptyR)
                {
                    // Plant a flower
                    flowerbed[i] = 1;
                    n--;

                    // Early exit if we've planted enough flowers
                    if (n == 0) return true;
                }
            }
        }

        return n <= 0;
    }
}