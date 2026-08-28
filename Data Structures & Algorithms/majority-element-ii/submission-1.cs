public class Solution {
    public List<int> MajorityElement(int[] nums) {
        Dictionary<int,int> map = new();
        List<int> result = new();
        foreach(int num in nums){
            if(map.ContainsKey(num)){
                map[num]++;
            }
            else map[num]=1;
        }
        foreach(var kvp in map){
            if(kvp.Value>nums.Length/3) result.Add(kvp.Key);
        }
        return result;
    }
}