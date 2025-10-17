import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

class Solution {
    public String reverseWords(String s) {
        s = s.trim();
        String[] words = s.split(" ");
        List<String> filteredWords = new ArrayList<>();

        for (String w : words) {
            if (!w.isEmpty() && !w.isBlank()) {
                filteredWords.add(w);
            }
        }

        Collections.reverse(filteredWords);
        return String.join(" ", filteredWords);
    }

    public String reverseWordsWithStringBuilder(String s) {
        s = s.trim();
        String[] words = s.split("\\s+"); 
        StringBuilder sb = new StringBuilder();

        for (int i = words.length - 1; i >= 0; i--) {
            sb.append(words[i]);
            if (i > 0)
                sb.append(" ");
        }
        
        return sb.toString();
    }
}