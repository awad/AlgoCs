public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        if(n<2) return n;
        int i = 1;
        
        for(int j = 1; j<n ; j++)
        {
            if(nums[j] != nums[j-1])
                nums[i++] = nums[j];
        }
        return i;
    }
}
