public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = 0, j = 0, count = 0;
        int[] arr = new int[m + n];

        while (i < m && j < n) {
            if (nums1[i] > nums2[j]) {
                arr[count] = nums2[j];
                j++;
            }
            else {
                arr[count] = nums1[i];
                i++;
            }
            count++;
        }
        while (i < m) {
            arr[count] = nums1[i];
            count++;
            i++;
        }

        while (j < n) {
            arr[count] = nums2[j];
            count++;
            j++;
        }

        for (int k = 0; k < arr.Length; k++) {
            nums1[k] = arr[k];
        }
    }
}