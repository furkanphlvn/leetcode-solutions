/**
 * @param {string} s
 * @return {string}
 */
var reverseVowels = function (s) {
    // c# ve java'daki helper methodunun js ve ts'de opsiyonel
    const vowels = new Set(['a', 'e', 'i', 'o', 'u']);
    const chars = s.split('');
    let left = 0;
    let right = chars.length - 1;

    while (left < right) {
        while(left < right && !vowels.has(chars[left].toLowerCase())) left++;
        while(left < right && !vowels.has(chars[right].toLowerCase())) right--;

        [chars[left], chars[right]] = [chars[right], chars[left]];
        left++;
        right--;
    }

    return chars.join('');
};