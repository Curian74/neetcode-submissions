public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length;
        int ans = nums.Length;
        while (l < r) {
            int m = l + (r - l) / 2;
            if (nums[m] >= target) {
                ans = m;
                r = m;
            }
            else if (nums[m] < target) {
                l = m + 1;
            }
        }
        return ans;
    }
}