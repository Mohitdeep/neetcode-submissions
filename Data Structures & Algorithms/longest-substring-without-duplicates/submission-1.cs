public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left =0;
        HashSet<char> set= new();
        int maxCount =0;
        int count =0;
        for(int right =0;right<s.Length;right++){
            while(set.Contains(s[right])){
                set.Remove(s[left]);
                left++;
                count--;
            }
            set.Add(s[right]);
            count++;
            maxCount = Math.Max(maxCount,count);
        }
        return maxCount;
    }
}
