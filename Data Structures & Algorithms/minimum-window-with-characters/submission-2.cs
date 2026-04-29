public class Solution {
    public string MinWindow(string s, string t) {
        var pDict = new Dictionary<char,int>();
        var sDict = new Dictionary<char, int>();

        foreach (char c in t) {
            if (pDict.ContainsKey(c)) {
                pDict[c]++;
            }
            else {
                pDict[c] = 1;
            }
        }
        int l = 0;
        int start = 0;
        int min = int.MaxValue;
        int need = pDict.Count;
        int have = 0;
        for (int r = 0; r < s.Length; r++) {
            if (sDict.ContainsKey(s[r])) {
                sDict[s[r]]++;
            }
            else {
                sDict[s[r]] = 1;
            }
            if (pDict.ContainsKey(s[r]) 
            && sDict[s[r]] == pDict[s[r]]) {
                have++;
            }
            while (have == need) {
                if (r - l + 1 < min) {
                    min = Math.Min(min, r - l + 1);
                    start = l;
                }
                
                sDict[s[l]]--;
                if (pDict.ContainsKey(s[l]) &&
                pDict[s[l]] > sDict[s[l]]) {
                    have--;
                }
                l++;

            }
        }
        return min == int.MaxValue ? "" : s.Substring(start, min);
    }
}
