public class Solution {
    public int MaxArea(int[] heights) {
        int start = 0;
        int end = heights.Length-1;
        int maxArea =0;
        while(start<end){

            int area = (end-start)*(Math.Min(heights[start],heights[end]));
            maxArea = Math.Max(area,maxArea);
            if(heights[start]>heights[end]) end--;
            else start++;
        }
        return maxArea;
    }
}
