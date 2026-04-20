public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0, j = s.Length - 1;

        while(i < j && i < s.Length){

            if(!char.IsLetter(s[j]) && !char.IsDigit(s[j])){
                j--;
            }

            else if(!char.IsLetter(s[i]) && !char.IsDigit(s[i])){
                i++;
            }

            else{
                if(char.ToLower(s[i]) != char.ToLower(s[j])) return false;
                i++;
                j--;
            }
            
        }

        return true;
    }
}
