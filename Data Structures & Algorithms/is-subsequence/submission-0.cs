public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i = 0; // pointer into s
        int j = 0; // pointer into t
        
        while (j < t.Length) {
            if (i < s.Length && t[j] == s[i]) i++;
            
j++;        }
        
        if(i==s.Length) return true;
        return false;
    }
}