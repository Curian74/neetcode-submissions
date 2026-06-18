public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        var stack = new Stack<int>();
        var res = new int[n];

        for (int i = 0; i < n; i++) {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i]) {
                int idx = stack.Pop();
                res[idx] = i - idx;
            }
            stack.Push(i);
        }

        return res;
    }
}
