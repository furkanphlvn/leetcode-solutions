public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        // bu pointer 0 olmayan sayıları sırayla dizinin önüne yerleştireceğimiz konumu tutar.
        int nonZero = 0;

        // diziyi dolaş
        // eğer nums[i] != 0 ise onu nums[nonZero]'ya taşı ve nonZero++ yap
        // eğer nums[i] == 0 ise bir şey yapma 
        for (int i = 0; i < nums.Length; i++)
        {
            // kontrol et eğer sayı sıfır değilse onu öne taşı
            if (nums[i] != 0)
            {
                nums[nonZero] = nums[i];
                nonZero++;
            }

        }

        // işlemler bitince, dizinin baş kısmında 0 olmayanlar sıralı biçimde olacak kalan kısımlara 0 yazılcak
        // [1, 3, 12, ?, ?]
        while (nonZero < nums.Length)
        {
            nums[nonZero] = 0;
            nonZero++;
        }
    }
}