public class Solution {
    public bool IsPalindrome(string s) {
        string s1 = s.ToLower().Trim();

        int n = s1.Length;
        int i = 0, j = n - 1;

        while (i < j) {
            if (!Char.IsLetterOrDigit(s1[i])) {
                i++;
            }
            if (!Char.IsLetterOrDigit(s1[j])) {
                j--;
            }
            if (Char.IsLetterOrDigit(s1[j]) && Char.IsLetterOrDigit(s1[i])) {
                if (s1[i] != s1[j]) return false;
                i++;
                j--;
            }
            
        }

        return true;
    }
}
