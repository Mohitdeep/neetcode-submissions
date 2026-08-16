public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26];
        int left = 0;
        int maxFreq = 0;
        int maxLen = 0;
        
        for (int right = 0; right < s.Length; right++) {

            count[s[right]-'A']++;
            
            maxFreq = Math.Max(maxFreq, count[s[right] - 'A']);
            
            int windowLen = right - left + 1;
            
            if(windowLen-maxFreq>k){
                count[s[left]-'A']--;
                left++;
            }
            
            maxLen = right- left +1;
        }
        
        return maxLen;
    }
}