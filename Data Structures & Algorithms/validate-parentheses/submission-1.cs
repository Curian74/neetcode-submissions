public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            }
            else {
                if (stack.Count == 0) return false;
                var p = stack.Pop();
                if (p == '{' && c != '}') return false;
                if (p == '(' && c != ')') return false;
                if (p == '[' && c != ']') return false;
            }
        }
        if (stack.Count > 0) return false;
        return true;
    }
}
