public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        var res = new List<List<string>>();

        foreach (string s in strs) {
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            string cur = new string(arr);

            if (!dict.ContainsKey(cur)) {
                dict.Add(cur, new List<string>{
                    s,
                });
            }
            else {
                dict[cur].Add(s);
            }
        }

        foreach (var kp in dict) {
            res.Add(kp.Value);
        }

        return res;
    }
}
