public class Solution {
    public int FindDuplicate(int[] nums) {
        var s = new HashSet<int>();

        foreach (int n in nums) {
            if (s.Contains(n)) return n;
            s.Add(n);
        }

        return -1;
    }
}
