function CanPlaceFlowers(flowerbed: number[], n: number): boolean {
    for (let i = 0; i < flowerbed.length && n > 0; i++) {
        if (flowerbed[i] === 0) {
            const emptyL: boolean = (i === 0) || (flowerbed[i - 1] === 0);
            const emptyR: boolean = (i === flowerbed.length - 1) || (flowerbed[i + 1] === 0);

            if(emptyL && emptyR)
            {
                flowerbed[i] = 1;
                n--;

                if(n===0) return true;
            }

        }
    }

    return n <= 0;
};