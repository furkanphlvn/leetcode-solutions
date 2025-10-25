import java.util.HashMap;

class Solution {
    public int maxOperations(int[] nums, int k) {
        HashMap<Integer, Integer> hashMap = new HashMap<>();
        int matchs = 0;

        for (int num : nums) {
            int complement = k - num;

            if (hashMap.containsKey(complement) && hashMap.get(complement) > 0) {
                matchs++;
                hashMap.put(complement, hashMap.get(complement) - 1);
            }
            else {
                hashMap.put(num, hashMap.getOrDefault(num, 0) + 1);
            }
        }

        return matchs;
    }
}