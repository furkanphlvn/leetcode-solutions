/**
 * @param {character[]} chars
 * @return {number}
 */
var compress = function(chars) {
    let ahmetW = 0, cihanR = 0; 

    while (cihanR < chars.length) {
        let currentChar = chars[cihanR];
        let count = 0;

        while (cihanR < chars.length && chars[cihanR] === currentChar) {
            cihanR++;
            count++;
        }

        chars[ahmetW] = currentChar;
        ahmetW++;

        if (count > 1) {
            for (let c of count.toString()) {
                chars[ahmetW] = c;
                ahmetW++;
            }
        }
    }

    return ahmetW;
};
