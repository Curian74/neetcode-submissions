public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        var res = new int[n - k + 1];

        for (int i = 0; i <= n - k; i++) {
            int max = nums[i];
            for (int j = i; j < i + k; j++) {
                max = Math.Max(max, nums[j]);
            }
            res[i] = max;
        }

        return res;
    }
}