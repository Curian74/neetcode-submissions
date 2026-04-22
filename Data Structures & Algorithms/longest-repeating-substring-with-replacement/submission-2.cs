public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict = new Dictionary<char, int>();
        int max = 0;
        int res = 0;
        int l = 0, r = 0;
        while (r < s.Length) {
            if (!dict.ContainsKey(s[r])) {
                dict[s[r]] = 1;
            }
            else {
                dict[s[r]]++;
            }
            max = Math.Max(dict[s[r]], max);
            while (r - l + 1 - max > k) {
                dict[s[l]]--;
                l++;
            }
            int w = r - l + 1;
            res = Math.Max(res, w);
            r++;
        }

        return res;
    }
}
