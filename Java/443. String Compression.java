class Solution {
    public int compress(char[] chars) {
        int cihanR = 0, ahmetW = 0; 

        while (ahmetW < chars.length) {
            char currentChar = chars[ahmetW];
            int count = 0;

            while (ahmetW < chars.length && chars[ahmetW] == currentChar) {
                ahmetW++;
                count++;
            }

            chars[cihanR] = currentChar;
            cihanR++;

            if (count > 1) {
                for (char c : Integer.toString(count).toCharArray()) {
                    chars[cihanR] = c;
                    cihanR++;
                }
            }
        }

        return cihanR;
    }
}
