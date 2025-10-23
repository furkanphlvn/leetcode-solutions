/**
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function (height) {
    let maxAlan = 0,
        sol = 0,
        sag = height.length - 1;

    while (sol < sag) {
        let genislik = sag - sol;
        let h = Math.min(height[sol], height[sag]);
        let alan = genislik * h;
        maxAlan = Math.max(maxAlan, alan);

        if (height[sol] < height[sag])
            sol++;
        else
            sag--;
    }

    return maxAlan;
};