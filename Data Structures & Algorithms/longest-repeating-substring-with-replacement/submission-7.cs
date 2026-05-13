public class Solution {
    public int CharacterReplacement(string s, int k) {
        var d = new Dictionary<char, int>();
        int l = 0;
        var maxFreq = int.MinValue;
        int res = 0;
        for (int r = 0; r < s.Length; r++) {
            if (d.ContainsKey(s[r])) {
                d[s[r]]++;
            }
            else {
                d[s[r]] = 1;
            }
            maxFreq = Math.Max(maxFreq, d[s[r]]);
            while (r - l + 1 - maxFreq > k) {
                d[s[l]]--;
                l++;
            }
            int w = r - l + 1;
            res = Math.Max(w, res);
        }

        return res;
    }
}
