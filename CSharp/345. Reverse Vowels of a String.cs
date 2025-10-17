public class Solution
{
    private static readonly HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

    public string ReverseVowels(string s)
    {
        // 1. stringi char array'e çevir (string immutable)
        char[] chars = s.ToCharArray();
        
        // 2. left ve right pointer oluştur
        int left = 0;
        int right = s.Length - 1;

        // 3. sesli harfleri tanımlayan bir helper fonksiyon yaz
        // Resolver()

        // 4. while (left < right) döngüsünde:
        while (left < right)
        {
            //      - left ilerle, sesli değilse atla
            if (!Resolver(chars[left]))
            {
                left++;
                continue;
            }

            //      - right geri git, sesli değilse atla
            if (!Resolver(chars[right]))
            {
                right--;
                continue;
            }

            //      - ikisi de sesliyse swap
            char newRight = chars[left];
            chars[left] = chars[right];
            chars[right] = newRight;

            //      - ikisini ilerlet
            left++;
            right--;
        }

        // 5. yeni string döndür
        return new string(chars);
    }

    // Helper fonksiyon
    private bool Resolver(char c) => vowels.Contains(char.ToLower(c));
}