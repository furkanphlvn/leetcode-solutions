public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
         int max = 0, current = 0;

         for(int i =0;i<nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                current++;

                if(current > max)
                max=current;
            }
            else
            {
                current = 0;
            }
        }

        return max;
    }
}