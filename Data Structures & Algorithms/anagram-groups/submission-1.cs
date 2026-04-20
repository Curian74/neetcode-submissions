public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            int[] arr = new int[26];
            foreach (char c in s) {
                arr[c - 'a']++;
            }
            string key = string.Join(",", arr);

            if (!dict.ContainsKey(key)) {
                dict.Add(key, new List<string>());
            }
            dict[key].Add(s);
        }

        return dict.Values.ToList();
    }
}
