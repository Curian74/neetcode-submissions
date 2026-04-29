public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length;
        while (l < r) {
            int m = l + (r - l) / 2;
            if (nums[m] == target) return m;
            if (nums[m] > target) {
                r = m;
            }
            else if (nums[m] < target) {
                l = m + 1;
            }
        }
        return l;
    }
}