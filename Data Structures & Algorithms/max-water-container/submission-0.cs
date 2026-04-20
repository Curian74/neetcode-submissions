public class Solution {
    public int MaxArea(int[] height) {
        int i = 0, j = height.Length - 1;
        int max = int.MinValue;

        while (i < j) {
            int min = Math.Min(height[i], height[j]);
            int w = j - i;
            int area = min * w;
            max = Math.Max(area, max);
            if (height[i] <= height[j]) {
                i++;
            }
            else if (height[i] >= height[j]) {
                j--;
            }
        }

        return max;
    }
}