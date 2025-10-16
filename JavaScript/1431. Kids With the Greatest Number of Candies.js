/**
 * @param {number[]} candies
 * @param {number} extraCandies
 * @return {boolean[]}
 */
var kidsWithCandies = function (candies, extraCandies) {
    const max = Math.max(...candies);
    return candies.map(c => c + extraCandies >= max);
};

var kidsWithCandiesLoop = function (candies, extraCandies) {
    const max = Math.max(...candies);
    const result = [];

    for (let i = 0; i < candies.length; i++) {
        if (candies[i] + extraCandies >= max)
            result.push(true);
        else
            result.push(false)
    }

    return result;
}