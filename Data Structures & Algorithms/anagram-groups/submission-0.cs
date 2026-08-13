public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        
        foreach (string s in strs) {
            char[] charArr = s.ToCharArray();
            Array.Sort(charArr);
            string charStr = new string(charArr); 
            if(map.ContainsKey(charStr)){
                map[charStr].Add(s);
            }
            else
            {
                map[charStr]=new List<string>{s};
            }            
        }
        
        return map.Values.ToList();
    }
}
