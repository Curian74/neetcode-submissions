public class Solution {
    public bool IsAnagram(string s, string t) {
        var dict = new Dictionary<char, int>();

        foreach (char c in s) {
            if (!dict.ContainsKey(c)) {
                dict[c] = 1;
            }
            else {
                dict[c]++;
            }
        }

        foreach (var v in dict.Values) {
            Console.WriteLine(v);
        }

        foreach (char c in t) {
            if (!dict.ContainsKey(c)) {
                return false;
            }
            dict[c]--;
        }

        return dict.Values.All(x => x == 0);
    }
}
