    class Solution {
        public int[] twoSum(int[] nums, int target) {
            Map<Integer, Integer> twoSumMap = new HashMap<>();

            for(int i = 0; i < nums.length; i++) {
                int comp = target - nums[i];

                if(twoSumMap.containsKey(comp)) {
                    return new int[] {twoSumMap.get(comp), i};
                }

                if(!twoSumMap.containsKey(nums[i])) {
                    twoSumMap.put(nums[i], i);
                }
            }
            return new int[0];
        }
    }