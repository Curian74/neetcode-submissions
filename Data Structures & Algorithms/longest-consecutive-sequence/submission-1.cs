public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>();

        foreach (int i in nums) {
            set.Add(i);
        }

        int max = 0;
        
        foreach (int i in set) {
            if (!set.Contains(i - 1)) {
                int count = 1;
                int value = i + 1;
                while (set.Contains(value)) {
                    count++;
                    value++;
                }
                max = Math.Max(count, max);
            }
        }

        return max;
    }
}