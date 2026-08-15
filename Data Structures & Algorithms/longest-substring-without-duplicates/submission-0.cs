public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> window = new HashSet<char>();
        int left = 0;
        int maxLen = 0;
        
        for (int right = 0; right < s.Length; right++) {
            char c = s[right];
            
            while (window.Contains(c)) {
                window.Remove(s[left]);
                left++;
            }
            
            window.Add(c);
            
            int currentLength = right - left + 1;
            maxLen = Math.Max(maxLen, currentLength);
        }
        
        return maxLen;
    }
}