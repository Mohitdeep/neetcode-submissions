public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
        int n = word1.Length;
        int m = word2.Length;
        
        char[] result = new char[m+n];
        for(int i=0;i<n+m;i++){
            if(i<Math.Min(n,m)*2){if(i%2==0) result[i] = word1[i/2];
            else result[i] = word2[i/2];}
            else result[i]= m>n?word2[i-n]:word1[i-m];
        }
        return new string(result);
    }
}