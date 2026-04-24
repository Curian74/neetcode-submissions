public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0, j = 0;
        var res = new StringBuilder();

        while (i < word1.Length && j < word2.Length) {
            res.Append(word1[i]);
            res.Append(word2[j]);
            i++;
            j++;
        }

        res.Append(word1.Substring(i));
        res.Append(word2.Substring(j));

        return res.ToString();
    }
}