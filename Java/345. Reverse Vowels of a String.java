import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

class Solution {
    private static final Set<Character> vowels = new HashSet<>(Arrays.asList('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'));

    public String reverseVowels(String s) {
        char[] chars = s.toCharArray();
        int left = 0;
        int right = chars.length - 1;

        while (left < right) {
            if (!resolver(chars[left])) {
                left++;
                continue;
            }

            if (!resolver(chars[right])) {
                right--;
                continue;
            }

            char newRight = chars[left];
            chars[left] = chars[right];
            chars[right] = newRight;

            left++;
            right--;
        }

        return new String(chars);
    }

    private boolean resolver(char c) {
        return vowels.contains(Character.toLowerCase((c)));
    }
}