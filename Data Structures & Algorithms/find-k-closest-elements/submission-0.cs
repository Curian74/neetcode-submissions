public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int l = 0, r = arr.Length - 1;
        var res = new List<int>();
        while (l <= r - k) {
            if (Math.Abs(arr[l] - x) > Math.Abs(arr[r] - x)) {
                l++;
            }
            else {
                r--;
            }
        }
        for (int i = l; i <= r; i++) {
            res.Add(arr[i]);
        }
        return res;
    }
}