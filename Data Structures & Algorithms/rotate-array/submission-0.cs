public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int[] res = new int[n];

        for (int i = 0; i < n; i++) {
            if (i < n - k) {
                res[i + k] = nums[i];
            }
            else {
                int d = (k + i) % n;
                res[d] = nums[i];
            }
        }

        for (int i = 0; i < n; i++) {
            nums[i] = res[i];
        }
    }
}