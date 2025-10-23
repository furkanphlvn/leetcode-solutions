class Solution {
    public int maxArea(int[] height) {
        int maxAlan = 0,
                sol = 0,
                sag = height.length - 1;

        while (sol < sag) {
            int genislik = sag - sol;
            int h = Math.min(height[sol], height[sag]);
            int alan = genislik * h;
            maxAlan = Math.max(maxAlan, alan);

            if (height[sol] < height[sag])
                sol++;
            else
                sag--;
        }

        return maxAlan;
    }
}