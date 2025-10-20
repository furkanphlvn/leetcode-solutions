public class Solution
{
    public int Compress(char[] chars)
    {

        // chars = ['a','a','b','b','c','c','c']
        // cihan = 0, ahmet = 0
        // - cihan=0 → currentChar = 'a'
        // - say count → 2
        // - ahmet 'a' → chars[0] = 'a', ahmet=1
        // - count>1 → yaz '2' → chars[1] = '2', ahmet=2

        // - cihan=2 → currentChar = 'b'
        // - say count → 2
        // - ahmet 'b' → chars[2] = 'b', ahmet=3
        // - count>1 → yaz '2' → chars[3] = '2', ahmet=4

        // - cihan=4 → currentChar = 'c'
        // - say count → 3
        // - ahmet 'c' → chars[4] = 'c', ahmet=5
        // - count>1 → yaz '3' → chars[5] = '3', ahmet= 6

        // return ahmet = 6
        ////////////////////////////////////
        
        int cihan = 0, ahmet = 0;

        while (cihan < chars.Length)
        {
            char crrnt = chars[cihan];
            int count  = 0;

            while (cihan < chars.Length && chars[cihan] == crrnt)
            {
                cihan++;
                count ++;
            }

            chars[ahmet] = crrnt;
            ahmet++;

            if (count  > 1)
            {
                foreach (char c in count.ToString())
                {
                    chars[ahmet] = c;
                    ahmet++;
                }
            }
        }

        return ahmet;
    }
}