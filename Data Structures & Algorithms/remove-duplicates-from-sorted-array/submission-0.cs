public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int last = 0;
        int count=1;
        for(int i =1;i<nums.Length;i++){
            if(nums[last]!=nums[i]) { nums[last+1]=nums[i]; last++; count++;}

        }
        return count;
    }
}