function KidsWithCandies(candies: number[], extraCandies: number): boolean[] {
    const max = Math.max(...candies);
    return candies.map(c => c + extraCandies >= max);
};

function KidsWithCandiesLoop(candies: number[], extraCandies: number): boolean[] {
    const max = Math.max(...candies);
    const result: boolean[] = [];

    for (let i = 0; i < candies.length; i++) {
        if (candies[i] + extraCandies >= max)
            result.push(true);
        else
            result.push(false);

    }

    return result;
};