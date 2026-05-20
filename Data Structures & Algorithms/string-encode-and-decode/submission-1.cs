public class Solution {

    public string Encode(IList<string> strs) {
        var bd = new StringBuilder();
        foreach (string s in strs) {
            bd.Append($"{s}€");
        }
        return bd.ToString();
    }

    public List<string> Decode(string s) {
        var list = new List<string>();
        var bd = new StringBuilder();
        foreach (char c in s) {
            if (c != '€') bd.Append(c);
            else {
                list.Add(bd.ToString());
                bd.Clear();
            }
        }

        return list;
   }
}
