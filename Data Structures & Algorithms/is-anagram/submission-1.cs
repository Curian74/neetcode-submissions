public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var dict1 = new Dictionary<char, int>();

        foreach (char c in s) {
            if (!dict1.ContainsKey(c)) {
                dict1.Add(c, 1);
            }
            else {
                dict1[c]++;
            }
        }

        foreach (char c in t) {
            if (dict1.ContainsKey(c)) {
                dict1[c]--;
            }
        }

        return dict1.Values.All(x => x == 0);
    }
}
