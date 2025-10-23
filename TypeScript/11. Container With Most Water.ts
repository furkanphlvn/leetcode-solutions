function MaxArea(height: number[]): number {
     let maxAlan: number = 0,
        sol: number = 0,
        sag: number = height.length - 1;

    while (sol < sag) {
        let genislik: number = sag - sol;
        let h: number = Math.min(height[sol], height[sag]);
        let alan: number = genislik * h;
        maxAlan = Math.max(maxAlan, alan);

        if (height[sol] < height[sag])
            sol++;
        else
            sag--;
    }

    return maxAlan;
};