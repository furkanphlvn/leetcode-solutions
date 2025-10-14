/**
 Do not return anything, modify nums1 in-place instead.
 */
function Merge(nums1: number[], m: number, nums2: number[], n: number): void {
    const result: number[] = [];
    let i = 0, j = 0;

    while(i < m && j < n) {
        if(nums1[i] <= nums2[j])
            result.push(nums1[i++]);
        else
            result.push(nums2[j++]);
    }

    while(i < m) result.push(nums1[i++]);
    while(j < n) result.push(nums2[j++]);

    for(let x = 0; x < result.length; x++) nums1[x] = result[x];
};