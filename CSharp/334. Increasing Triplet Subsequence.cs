
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
        //    bir üçüncü sayı bulmak (nums[k]) ki first < second < nums[k]
        int first = int.MaxValue;
        int second = int.MaxValue;

        // 3. nums dizisini sırayla dolaş:
        //      - foreach ile döngüye al
        foreach (int num in nums)
        {
            // - eğer mevcut sayı (num), first'ten küçük veya eşitse
            // - bu sayı şu ana kadar gördüğümüz en küçük sayı olur
            // - nums = [5, 1, 6] → ilk turda first=5, ikinci turda first=1
            if (num <= first)
            {
                first = num;

            }

            // - eğer num, first'ten büyük ama second'tan küçük veya eşitse
            // - yeni bir ikinci küçük sayı bulduk
            // - "first < second" sırasını koruyoruz
            // - nums = [1, 3, 2] → first=1, second=2 olur
            else if (num <= second)
            {
                second = num;
            }

            // - eğer num, hem first hem de second'dan büyükse
            // - bu durumda artan bir üçlü bulduk: first < second < num.
            // - nums = [1, 2, 3] bu durumda return true.
            else
            {
                return true;
            }
        }

        // 4. Döngü bittiyse return false
        return false;
    }
}
