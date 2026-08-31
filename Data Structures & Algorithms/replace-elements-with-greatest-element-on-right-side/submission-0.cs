public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        int maxSoFar = -1;
        
        for (int i = n - 1; i >= 0; i--) {

            int curr = arr[i];
            arr[i]=maxSoFar;
            
            maxSoFar = Math.Max(maxSoFar, curr);
        }
        
        return arr;
    }
}