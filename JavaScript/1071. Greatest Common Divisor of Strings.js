/**
 * @param {string} str1
 * @param {string} str2
 * @return {string}
 */
var gcdOfStrings = function (str1, str2) {
    if ((str1 + str2) != (str2 + str1)) return "";

    var result = resolver(str1.length, str2.length);
    return str1.substring(0, result);
};

function resolver(a, b) {
    if (b === 0) return a;

    return resolver(b, a % b);
}