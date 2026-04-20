public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;

        int i = 0, j = 1;

        while (j < prices.Length) {
            if (prices[j] < prices[i]) {
                i = j;
            }
            int sum = prices[j] - prices[i];
            max = Math.Max(sum, max);
            j++;
        }

        return max;
    }
}
