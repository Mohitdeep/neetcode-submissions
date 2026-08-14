public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hashSet = new HashSet<int>(nums);
        int maxLength = 0;
        foreach(int num in nums){
            if(!hashSet.Contains(num-1)){
                int length =1;
                int temp=num+1;
                while(hashSet.Contains(temp)){
                    length++;
                    temp++;
                }
                maxLength = Math.Max(length,maxLength);
            }
        }
        return maxLength;
    }
}
