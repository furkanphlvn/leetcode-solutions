public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //nums1 = [1,2,3,0,0,0], m = 3
        //nums2 = [2,5,6], n = 2
        //result ->  nums1 = [1,2,2,3,5,6]

        int[] result = new int[m + n];
        //result = [_,_,_,_,_,_]

        int i = 0, j = 0, k = 0;
        //i for nums1, j for nums2, k for result(merged array)

        while(i < m && j < n) { 
            //nums1 = [1,2,3,0,0,0], nums2 = [2,5,6]
            //i=0, j=0    nums1[i]=1, nums2[j]=2
            if(nums1[i] <= nums2[j]) {
                result[k++] = nums1[i++]; 
                //result[0] = 1
            }
            else {
                result[k++] = nums2[j++];
                //result[0] = 2
            }
        }      
        //after loop ends, one array may still have leftovers

        while(i < m){
            //if nums1 still has elements left
            result[k++] = nums1[i++];
        }

        while(j < n){
            //if nums2 still has elements left
            result[k++] = nums2[j++];
        }

        //copy merged array back into nums1
        for(int x = 0; x < result.Length; x++){
            nums1[x] = result[x];
        }
        //nums1 = [1,2,2,3,5,6]
    }
}