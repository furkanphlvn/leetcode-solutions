
public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        // 1. Eğer dizi 3’ten küçükse zaten üçlü oluşturulamaz, direkt false dön.
        //    Örneğin [1,2] -> false
        if (nums.Length < 3) return false;

        // 2. İki değişken tutacağız:
        //    - first: şu ana kadar gördüğümüz en küçük değer
        //    - second: first’ten sonra gelen en küçük ikinci değer
        //    Amacımız: bir üçüncü sayı bulmak (nums[k]) ki first < second < nums[k]
        int first = int.MaxValue;
        int second = int.MaxValue;

        // 3. nums dizisini sırayla dolaş:
        //      - foreach ile döngüye al
        //      - else if nums[i] <= second → second = nums[i]
        //      - else → hem first hem second’tan büyük bir sayı bulduk → return true
        foreach (int num in nums)
        {
            if (num <= first)
            {
                first = num;
                // nums= [5, 1, 6]
                // first = 5 -> sonra 1 gelir first artık 1 olur
            }
            else if (num <= second)
            {
                second = num;
                // nums = [1, 2, 6]
                // first = 1, second = 2
            }
            else
            {
                return true;
            }
        }

        // 4. Döngü bittiyse → hiçbir üçlü bulunmadı → return false
        return false;
    }
}
