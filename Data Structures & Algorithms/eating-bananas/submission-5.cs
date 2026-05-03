public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = piles.Max();

        while (l < r) {
            int k = (l + r) / 2;

            long totalTime = 0;
            foreach (int p in piles) {
                totalTime += (int)Math.Ceiling((double)p / k);
            }
            if (totalTime <= h) {
                r = k;
            }
             else {
                l = k + 1;
            }
        }
        return l;
    }
}