public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int res = int.MaxValue;
        int l = 0;
        int sum = 0;
        for (int r = 0; r < nums.Length; r++) {
            sum += nums[r];
            while (sum >= target) {
                res = Math.Min(res, r - l + 1);
                sum -= nums[l];
                l++;
            }
        }

        return res == int.MaxValue ? 0 : res;
    }
}