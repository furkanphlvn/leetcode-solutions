public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        // check if str1 + str2 is equal to str2 + str1
        if (!(str1 + str2).Equals(str2 + str1)) return "";

        // find the greatest common divisor of the lengths of str1 and str2
        int result = resolver(str1.Length, str2.Length);

        // return the substring of str1 from index 0 to result
        return str1.Substring(0, result);
    }

    // find the greatest common divisor
    private int resolver(int a, int b)
    {
        // base case
        if (b == 0) return a;

        // recursive case
        return resolver(b, a % b);
    }

}

