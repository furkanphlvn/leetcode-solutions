import java.util.*;
import java.util.stream.*;

class Solution {
    public List<Boolean> kidsWithCandies(int[] candies, int extraCandies) {
        int max = Arrays.stream(candies).max().getAsInt();
        List<Boolean> result = new ArrayList<>();

        for (int candy : candies)
            result.add(candy + extraCandies >= max);

        return result;
    }

    public List<Boolean> kidsWithCandiesStreamAPI(int[] candies, int extraCandies) {
        int max = Arrays.stream(candies).max().getAsInt();

        return Arrays.stream(candies).mapToObj(c -> c + extraCandies >= max).collect(Collectors.toList());
    }
}