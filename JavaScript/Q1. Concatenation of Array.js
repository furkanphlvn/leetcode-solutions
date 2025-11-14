/**
 * @param {number[]} nums
 * @return {number[]}
 */
var getConcatenation = function (nums) {
    const n = nums.length;
    const result = new Array(2 * n);
    for (let i = 0; i < n; i++) {
        result[i] = nums[i];
        result[i + n] = nums[i];
    }
    return result;
};