/**
 * @param {string} s
 * @param {number} k
 * @return {number}
 */
var maxVowels = function(s, k) {
      const sesliHarfler = new Set(['a', 'e', 'i', 'o', 'u']);
  let bulunanMaxSesliHarf = 0;
  let sayac = 0;

  for (let i = 0; i < s.length; i++) {
    if (sesliHarfler.has(s[i])) sayac++;

    if (i >= k && sesliHarfler.has(s[i - k])) sayac--;

    if (i >= k - 1)
      bulunanMaxSesliHarf = Math.max(sayac, bulunanMaxSesliHarf);
  }

  return bulunanMaxSesliHarf;
};