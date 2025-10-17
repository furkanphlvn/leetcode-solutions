function ReverseWords(s: string): string {
    s = s.trim();
    const words: string[] = s.split(' ');
    const filteredWords: string[] = words.filter(word => word.length > 0);
    filteredWords.reverse();
    return filteredWords.join(' ');
    //return s.trim().split(/\s+/).reverse().join(' ');
};