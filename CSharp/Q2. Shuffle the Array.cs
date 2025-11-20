
class Solution
{
    public int[] shuffle(int[] nums, int n)
    {
        // nums = [x1, x2, x3, ..., xn,  y1, y2, y3, ..., yn]
        //          ↑  ↑  ↑               ↑   ↑  ↑  
        //        ilk n eleman          sonraki n eleman
        //            X'ler              Y'ler
        // çıktısı [ x1, y1,  x2, y2,  x3, y3, ..., xn, yn ]

        int[] result = new int[2 * n];

        for (int i = 0; i < n; i++)
        {
            // X elemanları
            result[2 * i] = nums[i];

            // Y elemanları
            result[2 * i + 1] = nums[i + n];
        }

        return result;
    }
}
