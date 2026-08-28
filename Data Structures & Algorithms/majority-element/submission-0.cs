public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> count = new();
        foreach(int num in nums){
            if(count.ContainsKey(num)) count[num]++;
            else count[num] = 1;
        }
        foreach(var kvp in count){
            if(kvp.Value>nums.Length/2) return kvp.Key;
        }
        return -1;
    }
}