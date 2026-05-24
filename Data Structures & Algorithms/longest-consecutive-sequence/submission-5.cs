public class Solution {
    public int LongestConsecutive(int[] nums) {
        int max = 0;
        var set = new HashSet<int>();

        foreach (var i in nums) {
            set.Add(i);
        }

        foreach (int i in set) {
            int count = 1;
            int value = i + 1;
            if (!set.Contains(i - 1)) {
                while (set.Contains(value)) {
                    count++;
                    value++;
                }
            }
            max = Math.Max(count, max);
        }

        return max;
    }
}
