public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int c = target - nums[i];

            if (dict.ContainsKey(c)) {
                return [dict[c], i];
            }

            if (!dict.ContainsKey(nums[i])) {
                dict[nums[i]] = i;
            }
        }

        return [];
    }
}
