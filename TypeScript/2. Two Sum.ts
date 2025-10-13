function twoSum(nums: number[], target: number): number[] {
    const twoSumMap: Map<number, number> = new Map();

    for(let i = 0; i < nums.length; i++) {
        const comp = target - nums[i];

        if(twoSumMap.has(comp)) {
            return [twoSumMap.get(comp)!, i];
        }

        if(!twoSumMap.has(nums[i])) {
            twoSumMap.set(nums[i], i);
        }
    }
    return[];
};