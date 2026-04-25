public class Solution {
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
        int max = int.MinValue;
        int l = 0;
        if (minutes > grumpy.Length) {
            int res = 0;
            foreach (int n in customers) {
                res += n;
            }
            return res;
        }
        for (int r = minutes - 1; r < customers.Length; r++) {
            var temp = new int[grumpy.Length];
            var sum = 0;
            for (int i = 0; i < customers.Length; i++) {
                if (i >= l && i <= r) {
                    temp[i] = grumpy[i] == 1 ? 0 : 0;
                }
                else {
                    temp[i] = grumpy[i];
                }
            }
            for (int i = 0; i < temp.Length; i++) {
                if (temp[i] == 0) {
                    sum += customers[i];
                }
            }
            max = Math.Max(max, sum);
            l++;
        }

        return max;
    }
}