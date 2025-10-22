public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        // s = "abc"
        // t = "ahbgdc"

        // 1. i=0 ('a'), j=0 ('a') -> eşleşti → i=1, j=1
        // 2. i=1 ('b'), j=1 ('h') -> eşleşmedi → j=2
        // 3. j=2 ('b') -> eşleşti → i=2, j=3
        // 4. i=2 ('c'), j=3 ('g') -> eşleşmedi → j=4
        // 5. j=4 ('d') -> eşleşmedi → j=5
        // 6. j=5 ('c') -> eşleşti → i=3

        // i == s.Length (3) → true 

        // iki pointer s ve t stringlerini sırayla gezecek şekilde
        int i = 0, j = 0; // s, t 

        // t'de s'in karakterlerini sırayla bulabilmek için döngü
        while (i < s.Length && j < t.Length)
        {
            // eğer karakterler eşitse, s'in pointer'ını ilerlet i++
            // çünkü s'in bu karakteri t'nin içnde bulundu s[i] = 'a', t[j] = 'a')
            if (s[i] == t[j]) i++;

            // her durumda t’nin pointer’ını ilerlet
            // çünkü t’deki sonraki karakteri kontrol etmemiz lazım
            j++;
        }

        // döngüden çıktıktan sonra 
        // eğer i == s.length ise , s'in tüm karakterleri t'de bulundu (yani subsequence’tir  true döneriz)
        // değilse false döneriz
        if (i == s.Length)
            return true;
        else
            return false;
        //return i == s.Length;
    }
}

