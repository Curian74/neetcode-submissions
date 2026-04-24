public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0, j = 0;
        var bd = new StringBuilder();
        bool leftTurn = true;
        while (i < word1.Length && j < word2.Length) {
            if (leftTurn) {
                bd.Append(word1[i]);
                i++;
            }
            else {
                bd.Append(word2[j]);
                j++;
            }
            leftTurn = !leftTurn;
        }
        
        while (i < word1.Length) {
            bd.Append(word1[i]);
            i++;
        }

        while (j < word2.Length) {
            bd.Append(word2[j]);
            j++;
        }

        return bd.ToString();
    }
}