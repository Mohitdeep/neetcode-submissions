public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> map = new();
        foreach(int num in nums){
            if(map.Contains(num)){
                return true;
            }
            else{
                map.Add(num);
            }
        }
        return false;
    }
}