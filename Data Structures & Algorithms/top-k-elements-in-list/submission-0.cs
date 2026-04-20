public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();

        foreach (int i in nums) {
            if (!dict.ContainsKey(i)) {
                dict[i] = 1;
            }
            else {
                dict[i]++;
            }
        }

        var res = dict
        .OrderByDescending(x => x.Value)
        .Take(k)
        .Select(x => x.Key)
        .ToArray();

        return res;
   }
}
