public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res = 0;
        int l = 0;
        int maxFreq = 0;
        var dict = new Dictionary<char, int>();
        for (int r = 0; r < s.Length; r++) {
            if (!dict.ContainsKey(s[r])) {
                dict[s[r]] = 1;
            }
            else {
                dict[s[r]]++;
            }
            maxFreq = Math.Max(dict[s[r]], maxFreq);
            while (r - l + 1 - maxFreq > k) {
                dict[s[l]]--;
                l++;
            }
            int w = r - l + 1;
            res = Math.Max(res, w);
        }

        return res;
    }
}
