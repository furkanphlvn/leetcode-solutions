function MaxOperations(nums: number[], k: number): number {
    const map: Map<number, number> = new Map();
    let matchs = 0;

    for (const num of nums) {
        const complement = k - num;

        if (map.has(complement) && (map.get(complement) ?? 0) > 0) {
            matchs++;
            map.set(complement, (map.get(complement) ?? 0) - 1);
        }
        else {
            // burayı çaldım :d
            map.set(num, (map.get(num) || 0) + 1);
        }
    }

    return matchs;
};