/**
 * @param {string} s
 * @return {string}
 */
var reverseWords = function (s) {
    s = s.trim();
    const words = s.split(' ');
    const filteredWords = words.filter(word => word.length > 0);
    filteredWords.reverse();
    return filteredWords.join(' ');
    //return s.trim().split(/\s+/).reverse().join(' ');
};