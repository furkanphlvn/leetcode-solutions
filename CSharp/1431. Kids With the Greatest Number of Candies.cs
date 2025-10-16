public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        if (candies == null || candies.Length == 0) return new List<bool>();
        int max = 0;

        // Find max candies
        foreach (int c in candies) if (c > max) max = c;
        // max = 12
        // candies = [2,3,5,1,3]  extraCandies = 3
        List<bool> result = new List<bool>(candies.Length);

        // Check each child
        for (int i = 0; i < candies.Length; i++)
        {
            // Calculate total candies if given extraCandies
            int total = candies[i] + extraCandies;
            // i=0, total = 2 + 3 = 5, 5 >= 12? false
            // i=1, total = 3 + 3 = 6, 6 >= 12? false
            // i=2, total = 5 + 3 = 8, 8 >= 12? false
            // i=3, total = 1 + 3 = 4, 4 >= 12? false
            // i=4, total = 3 + 3 = 6, 6 >= 12? false

            // Check if can have the greatest number of candies
            bool maxFound = total >= max;
            // i=0, maxFound = false
            // i=1, maxFound = false
            // i=2, maxFound = false
            // i=3, maxFound = false
            // i=4, maxFound = false

            // Add result
            result.Add(maxFound);
        }

        return result;
    }

    public IList<bool> KidsWithCandiesLINQ(int[] candies, int extraCandies)
    {
        // LINQ approach
        if (candies == null || candies.Length == 0) return new List<bool>();
        int max = candies.Max();
        // max = 12
        // candies = [2,3,5,1,3]  extraCandies = 3
        var result = candies.Select(x => x + extraCandies >= max).ToList();
        // i=0, total = 2 + 3 = 5, 5 >= 12? false
        // i=1, total = 3 + 3 = 6, 6 >= 12? false
        // i=2, total = 5 + 3 = 8, 8 >= 12? false
        // i=3, total = 1 + 3 = 4, 4 >= 12? false
        // i=4, total = 3 + 3 = 6, 6 >= 12? false
        
        // Add result
        return result;
    }
}
