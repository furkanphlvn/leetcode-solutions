public class Solution
{
    public int MaxVowels(string s, int k)
    {
        HashSet<char> sesliHarfler = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        int bulunanMaxSesliHarf = 0, sayac = 0;

        //karakterleri sırayla gez
        for (int i = 0; i < s.Length; i++)
        {
            // sesli ise sayacı artır
            if (sesliHarfler.Contains(s[i]))
                sayac++;

            // sol tarafı ilerlet (k’yı geçtiyse)
            if (i >= k && sesliHarfler.Contains(s[i - k]))
                sayac--;

            // i >= k’ya ulaştıysa bulunanMaxSesliHarf güncelle
            if (i >= k - 1)
                bulunanMaxSesliHarf = Math.Max(sayac, bulunanMaxSesliHarf);
        }

        return bulunanMaxSesliHarf;
    }
}