public class Solution {
    public int CalPoints(string[] operations) {
        var st = new Stack<int>();
        int res = 0;

        foreach (string s in operations) {
            if (int.TryParse(s, out int num)) {
                st.Push(num);
            }
            else if (s == "+") {
                int temp = st.Pop();
                int top = st.Peek();
                int sum = top + temp;
                st.Push(temp);
                st.Push(sum);
            }
            else if (s == "C") {
                st.Pop();
            }
            else if (s == "D") {
                st.Push(st.Peek() * 2);
            }
        }
        foreach (int n in st) {
            res += n;
        }

        return res;
    }
}