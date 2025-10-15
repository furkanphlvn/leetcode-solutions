function GcdOfStrings(str1: string, str2: string): string {
    if ((str1 + str2) !== (str2 + str1)) return "";

    const result: number = resolve(str1.length, str2.length);

    return str1.substring(0, result);
};

function resolve(a: number, b: number): number {
    if (b === 0) return a;
    return resolve(b, a % b);
}