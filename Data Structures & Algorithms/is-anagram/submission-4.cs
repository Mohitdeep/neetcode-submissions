public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length) return false;
        Dictionary<char,int> map = new();
        for(int i =0;i<s.Length;i++){
            if(map.ContainsKey(s[i]))
            map[s[i]]++;
            else map[s[i]] =1;

            if(map.ContainsKey(t[i]))
            map[t[i]]--;
            else map[t[i]] =-1;
        }
        foreach(var kvp in map){
if(kvp.Value!=0) return false;
        }
        return true;
    }
}
