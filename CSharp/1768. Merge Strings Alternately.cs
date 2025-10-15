using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        //word1 = "abc", word2 = "pqr"
        //result -> "apbqcr"
        var result = new StringBuilder();
        int i = 0;

        //abc, pqr
        //i=0   word1[0]=a, word2[0]=p  result = "ap"       
        while (i < word1.Length || i < word2.Length)
        {
            if (i < word1.Length) result.Append(word1[i]); //append char from word1 if available
            if (i < word2.Length) result.Append(word2[i]); //append char from word2 if available
            i++; //move to next index
        }
        
        return result.ToString(); //result = "apbqcr"
    }
}