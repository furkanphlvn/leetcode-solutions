using System.IO.Pipelines;

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        //  İlk pencerenin toplamını al
        //float toplam = 0;
        // long kullanılması gerekiyor :D
        long toplam = 0;
        for (int i = 0; i < k; i++)
        {
            toplam += nums[i];
        }

        // ilk pencerenin toplamıyla başlat
        // float maksToplam = toplam;
        // bu değişkende long olması gerekiyor
        long maksToplam = toplam;

        // pencereyi kaydırarak ilerliyoruz i k'dan başlayacak, her adımda bir eleman giricek şekilde, bir eleman çıkar
        for (int i = k; i < nums.Length; i++)
        {
            // - yeni giren elemanı ekle
            toplam += nums[i];

            // - i-k 'dan çıkan indeksliyi çıkar
            toplam -= nums[i - k];

            if (toplam > maksToplam) maksToplam = toplam;
        }

        // double bölme için cast gerekiyor (yoksa tam sayı bölmesi olur!) :D
        // double result = maksToplam / k;
        double result = (double)maksToplam / k;
        return result;
    }
}

        