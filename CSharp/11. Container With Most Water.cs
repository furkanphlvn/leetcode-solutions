public class Solution
{
    public int MaxArea(int[] height)
    {
        // amaç height[left] ve height[right] çizgileriyle oluşan alanı maksimum yapmak.
        // Alan = (right - left) * min(height[left], height[right])
        //        (  genişlik  )      (         yükseklik         )
        
        int maxAlan = 0,           // bulunan maksimum su alanını tutacak değişken
        left = 0,                  // dizinin başı
        right = height.Length - 1; // dizinin sonu

        // ikisi birbirini geçene kadar devam 
        while (left < right)
        {
            // genişlik
            int width = right - left;

            // yükseklik kısa olan cizgi (suyun ordan taşması ?)
            int h = Math.Min(height[left], height[right]);

            // Alan = genişlik * yükseklik
            int alan = width * h;

            // eğer bu alandaha büüykse maxAlan'ı güncelle
            maxAlan = Math.Max(maxAlan, alan);

            // burada hangi pointerı hareket ettiricez ona bakmalıyız
            // kısa olan cizgiyi içe kaydırmak, kısa olanı büyütme şansımız var
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxAlan;
    }
}