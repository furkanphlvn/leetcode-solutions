public class Solution
{
    // Product Dizisi Hariç Kendisi
    // Verilen bir tamsayı dizisi nums, her nums[i] için, nums dizisindeki tüm elemanların çarpımını döndüren bir dizi döndürün, nums[i] hariç.
    // Çözüm, bölme işlemi kullanmadan O(n) zaman karmaşıklığında çalışmalıdır.
    // Girdi: nums = [1,2,3,4]
    // Çıktı: [24,12,8,6]
    public int[] ProductExceptSelf(int[] nums)
    {
        // sonuç dizisi
        int[] result = new int[nums.Length];

        // sol ve sağ çarpanlar
        int left = 1;
        int right = 1;

        //sol tarafın çarpımı
        //i = 0'dan başla ve nums.Length'e kadar git
        for (int i = 0; i < nums.Length; i++)
        {
            //şu anki sol çarpanı ata
            result[i] = left;
            //şu anki sayıyı sol çarpana ekle
            left *= nums[i];
            //örneğin: nums = [1,2,3,4]
            //i = 0 -> result[0] = 1, left = 1
            //i = 1 -> result[1] = 1, left = 2
            //i = 2 -> result[2] = 2, left = 6
            //i = 3 -> result[3] = 6, left = 24
            //şimdi result = [1,1,2,6]
        }

        //sağ tarafın çarpımı
        //i = nums.Length - 1'den başla ve 0'a kadar git
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            //şu anki sağ çarpanı mevcut sonuçla çarp
            result[i] *= right;
            //şu anki sayıyı sağ çarpana ekle
            right *= nums[i];
            //örneğin: nums = [1,2,3,4]
            //i = 3 -> result[3] = 1 * 1, right = 4
            //i = 2 -> result[2] = 1 * 4, right = 12
            //i = 1 -> result[1] = 2 * 12, right = 24
            //i = 0 -> result[0] = 6 * 24, right = 24   
            //şimdi result = [24,12,8,6]
        }

        return result;
    }
}