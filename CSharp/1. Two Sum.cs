public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //nums = [3,5,7]   target = 8  --> 5+3
        Dictionary<int, int> twoSum = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
        //i=0, nums[0] = 3
        //i=1, nums[1] = 5
        //i=2, nums[2] = 7

            int comp = target - nums[i];
            //i=0, comp = 8 - 3 = 5
            //i=1, comp = 8 - 5 = 3
            //i=2, comp = 8 - 3 = 1

            //if previously added
            if(twoSum.ContainsKey(comp)) {
                //i=0, twoSum.ContainsKey(5)?  false
                //i=1, twoSum.ContainsKey(3)?  true
                //i=2, twoSum.ContainsKey(1)?  false

                return new int[] { twoSum[comp], i}; //match
                //i=1, return [0,1] match
            }

            //add number to dictionary
            if(!twoSum.ContainsKey(nums[i])) {
                //i=0, twoSum[3] = 0
                //i=1, twoSum[5] = 1
                //i=2, twoSum[7] = 2
                twoSum[nums[i]] = i;
            }
        }
        //no match empty array
        return new int[0];
    }
}