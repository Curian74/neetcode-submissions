public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 0, r = piles.Max();
        while (l < r) {
            int m = l + (r - l) / 2;
            long hs = 0;
            foreach (int p in piles) {
                hs += (int)Math.Ceiling((double) p / m);
            }
            if (hs <= h) {
                r = m;
            }
            else {
                l = m + 1;
            }
        }

        return l;
    }
}
