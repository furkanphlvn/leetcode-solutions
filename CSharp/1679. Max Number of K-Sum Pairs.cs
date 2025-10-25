public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        // 1. HashMap (Dictionary<int, int>) oluştur sayıları ve adetlerini tut
        Dictionary<int, int> hashMap = new Dictionary<int, int>();

        // toplam kaç eşleşme bulduğumuzu tutacak sayaç
        int matchs = 0;

        // 2. nums dizisini sırayla dolaş
        for (int i = 0; i < nums.Length; i++)
        {
            //    - complement = k - nums[i]
            int num = nums[i];
            int complement = k - num;

            //    - Eğer complement HashMap’te varsa eşleşme buldun
            if (hashMap.ContainsKey(complement) && hashMap[complement] > 0)
            {
                // matchs++
                matchs++;

                // complement’in sayısını 1 azalt
                hashMap[complement]--;
            }
            else
            {
                //    - Yoksa nums[i] sayısını HashMap’e ekle
                if (!hashMap.ContainsKey(num))
                {
                    hashMap[num] = 0;
                }

                hashMap[num]++;
            }
        }

        // 3. Tüm elemanlar bitince matchs sayısını döndür
        return matchs;
    }
}