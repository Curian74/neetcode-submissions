public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = piles.Max();

        while (l < r) {
            int m = l + (r - l) / 2;
            long hSpent = 0;
            foreach (int p in piles) {
                hSpent += (p + m - 1) / m;
            }
            if (hSpent <= h) {
                r = m;
            } 
            else {
                l = m + 1;
            }
        }

        return l;
    }
}
