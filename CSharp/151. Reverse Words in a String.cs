using System.Text;

public class Solution
{
    public string ReverseWords(string s)
    {

        // 1. baş ve sondaki boşlukları kaldır
        s = s.Trim();

        // 2. kelimeleri ayır (araya boşluk)
        string[] words = s.Split(' ');

        // 3. boş stringleri çıkar (artık boşluk varsa)
        List<string> filteredWords = new List<string>();
        foreach (var w in words)
        {
            if (!string.IsNullOrEmpty(w))
                filteredWords.Add(w);
        }

        // 4. kelimeleri ters sıraya çevir
        filteredWords.Reverse();

        // 5️. boşlukla birleştir
        return string.Join(" ", filteredWords);
    }

    // StringBuilder ile yapımı
    public string ReverseWordsWithStringBuilder(string s)
    {
        s = s.Trim();
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var sb = new StringBuilder();

        for (int i = words.Length - 1; i >= 0; i--)
        {
            sb.Append(words[i]);
            if (i > 0) sb.Append(' ');
        }
        
        return sb.ToString();
    }

}