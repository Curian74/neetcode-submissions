public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        var set = new HashSet<int>();
        int max = int.MinValue;
        
        foreach (int n in nums) {
            set.Add(n);
        }

        foreach (int n in set) {
            if (!set.Contains(n - 1)) {
                int count = 1;
                int value = n + 1;
                while (set.Contains(value)) {
                    value++;
                    count++;
                }
                max = Math.Max(count, max);
            }
        }

        return max;
    }
}
