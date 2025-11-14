public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        // n: giriş dizisinin uzunluğu
        int n = nums.Length;

        // Sonuç dizisi: uzunluğu 2n
        int[] result = new int[2 * n];

        // i: 0..n-1 arasında gezer
        for (int i = 0; i < n; i++)
        {
            // İlk yarıya doğrudan kopyala
            result[i] = nums[i];

            // İkinci yarıya da aynı elemanı kopyala
            result[i + n] = nums[i];
        }

        // Sonucu döndür
        return result;
    }
}