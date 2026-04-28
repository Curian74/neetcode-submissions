public class Solution {
    public int MySqrt(int x) {
        int l = 1, r = x;
        while (l <= r) {
            int m = l + (r - l) / 2;
            long sqrt = (long) m * m;
            if (sqrt == x) return m;
            if (sqrt > x) {
                r = m - 1;
            }
            else if (sqrt < x) {
                l = m + 1;
            }
        }

        return l - 1;
    }
}