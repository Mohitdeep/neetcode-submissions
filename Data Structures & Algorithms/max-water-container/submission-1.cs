public class Solution {
    public int MaxArea(int[] heights) {
        int left =0;
        int right = heights.Length-1;
        int maxArea = 0;
        while(left<right){
            int min = Math.Min(heights[left],heights[right]);
            int area = min*(right-left);
            maxArea = Math.Max(maxArea,area);
            if(min == heights[left]) left++;
            else right--;
        }
        return maxArea;
    }
}
