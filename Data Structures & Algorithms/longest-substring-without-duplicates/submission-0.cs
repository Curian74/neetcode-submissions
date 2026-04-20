public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        int j = 0, i = 0;
        var set = new HashSet<char>();

        while (j < s.Length) {
            while (set.Contains(s[j])) {
                set.Remove(s[i]);
                i++;
            }
            int w = j - i + 1;
            max = Math.Max(w, max);
            set.Add(s[j]);
            j++;
        }

        return max;
    }
}
