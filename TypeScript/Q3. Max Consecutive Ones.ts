function FindMaxConsecutiveOnes(nums: number[]): number {
    let max: number = 0, current: number = 0;

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
