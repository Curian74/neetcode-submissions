public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res = 0;
        for (int i = 0; i < s.Length; i++) {
            var dict = new Dictionary<char, int>();
            var maxFreq = 0;
            for (int j = i; j < s.Length; j++) {
                if (dict.ContainsKey(s[j])) {
                    dict[s[j]]++;
                }
                else {
                    dict[s[j]] = 1;
                }
                maxFreq = Math.Max(maxFreq, dict[s[j]]);
                int w = j - i + 1;
                if (w - maxFreq <= k) {
                    res = Math.Max(res, w);
                }
            }
        }

        return res;
    }
}
