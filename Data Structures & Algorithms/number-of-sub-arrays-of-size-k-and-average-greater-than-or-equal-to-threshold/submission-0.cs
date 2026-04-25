public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int res = 0;
        int curSum = 0;
        for (int i = 0; i < k; i++) {
            curSum += arr[i];
        }
        if (curSum / k >= threshold) {
            res++;
        }
        int l = 0;
        for (int r = k; r < arr.Length; r++) {
            curSum -= arr[l];
            curSum += arr[r];
            int avg = curSum / k;
            if (avg >= threshold) res++;
            l++;
        }

        return res;
    }
}