public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int min = strs[0].Length;
        foreach (string s in strs) {
            if (s.Length < min)
            min = s.Length;
        }
        int i = 0;
        for (; i < min; i++) {
            foreach (string s in strs) {
                if (s[i] != strs[0][i]){
                    return strs[0].Substring(0, i);
                }
            }
        }
        return strs[0].Substring(0, i);
    }
}