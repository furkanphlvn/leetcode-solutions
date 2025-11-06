import java.util.HashSet;
import java.util.Set;

class Solution {
    public int maxVowels(String s, int k) {
        Set<Character> sesliHarfler = new HashSet<>();
        for (char c : new char[] { 'a', 'e', 'i', 'o', 'u' }) {
            sesliHarfler.add(c);
        }
        
        int bulunanMaxSesliHarf = 0;
        int sayac = 0;

        for (int i = 0; i < s.length(); i++) {
            if (sesliHarfler.contains(s.charAt(i)))
                sayac++;

            if (i >= k && sesliHarfler.contains(s.charAt(i - k)))
                sayac--;

            if (i >= k - 1)
                bulunanMaxSesliHarf = Math.max(bulunanMaxSesliHarf, sayac);
        }

        return bulunanMaxSesliHarf;
    }
}