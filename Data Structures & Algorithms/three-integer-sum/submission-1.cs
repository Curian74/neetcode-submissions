public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++) {
            // skip the check if we found the same number as prev
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            int j = i + 1, k = nums.Length - 1;
            // iterate when j < k
            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];
                if (sum > 0) {
                    k--;
                }
                else if (sum < 0) {
                    j++;
                }

                // found the triplet, add res and increment j by 1
                else {
                    res.Add(new List<int>() {
                        nums[i],
                        nums[j],
                        nums[k],
                    });
                    j++;

                    // skip current number if nums[j] = nums[j - 1]
                    while (j < k && nums[j] == nums[j - 1]) {
                        j++;
                    }
                }
            }
        }

        return res;
    }
}
