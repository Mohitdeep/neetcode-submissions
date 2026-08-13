public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder strB = new();
        foreach(string str in strs){
            strB.Append($"{str.Length}#{str}");
        }
        return strB.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int i = 0;
    
    while (i < s.Length) {

        int ind=s.IndexOf('#', i);
        int len = int.Parse(s.Substring(i,ind-i));

        string str = s.Substring(ind+1,len);

        i=ind+len+1;
        result.Add(str);
    }
    
    return result;
   }
}
