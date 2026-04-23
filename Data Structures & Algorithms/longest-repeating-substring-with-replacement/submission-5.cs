public class Solution {
    public int CharacterReplacement(string s, int k) {
        var set = new HashSet<char>(s);
        var res = 0;
        foreach (char c in set) {
            int count = 0;
            int l = 0;
            for (int r = 0; r < s.Length; r++) {
                if (s[r] == c) {
                    count++;
                }
                while (r - l + 1 - count > k) {
                    if (s[l] == c) {
                        count--;
                    }
                    l++;
                }
                int w = r - l + 1;
                res = Math.Max(w, res);
            }
        }

        return res;
    }
}
