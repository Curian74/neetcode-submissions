public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length) return false;
        var s1Count = new int[26];
        var s2Count = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        if (s1Count.SequenceEqual(s2Count)) return true;

        int l = 0, r = s1.Length;
        while (r < s2.Length) {
            s2Count[s2[l] - 'a']--;
            s2Count[s2[r] - 'a']++;
            if (s1Count.SequenceEqual(s2Count)) return true;
            l++;
            r++;
        }

        return false;
    }
}