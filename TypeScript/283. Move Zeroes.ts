/**
 Do not return anything, modify nums in-place instead.
 */
function MoveZeroes(nums: number[]): void {
    let nonZero = 0;

    for(let i = 0; i < nums.length; i++)
    {
        if(nums[i] != 0)
        {
            nums[nonZero] = nums[i];
            nonZero++;
        }
    }

    while(nonZero < nums.length)
    {
        nums[nonZero] = 0;
        nonZero++;
    }
};