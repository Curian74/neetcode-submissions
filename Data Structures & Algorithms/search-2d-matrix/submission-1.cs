public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for (int i = 0; i < matrix.Length; i++) {
            int l = 0, r = matrix[i].Length - 1;
            while (l <= r) {
                int m = l + (r - l) / 2;
                if (matrix[i][m] == target) return true;
                if (matrix[i][m] < target)
                l = m + 1;
                else if (matrix[i][m] > target) {
                    r = m - 1;
                }
            }
        }
        return false;
    }
}
