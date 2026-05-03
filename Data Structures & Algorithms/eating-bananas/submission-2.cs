public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int res = int.MaxValue;
        for (int i = 1; ; i++) {
            long hSpent = 0;
            foreach (int j in piles) {
                if (hSpent > h) break;
                if (j < i) hSpent += 1;
                else {
                    double d = Math.Ceiling((double)j / i);
                    hSpent += (long)d;
                }
            }
            if (hSpent <= h) {
                res = Math.Min(res, i);
                break;
            }
        }

        return res;
    }
}
