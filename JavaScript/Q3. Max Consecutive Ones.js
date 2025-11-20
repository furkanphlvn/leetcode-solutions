/**
 * @param {number[]} nums
 * @return {number}
 */
var findMaxConsecutiveOnes = function(nums) {
    let max = 0, current = 0;

    for (let i = 0; i < nums.length; i++) {
        if (nums[i] === 1) {
            current++;
            if (current > max) max = current;
        } else {
            current = 0;
        }
    }

    return max;
}
