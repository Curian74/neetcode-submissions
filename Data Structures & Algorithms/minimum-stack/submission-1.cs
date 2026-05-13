public class MinStack {
    Stack<int> min = new Stack<int>();
    Stack<int> st = new Stack<int>();
    int curMin = int.MaxValue;

    public MinStack() {
        
    }
    
    public void Push(int val) {
        st.Push(val);
        val = Math.Min(val, min.Count == 0 ? val : min.Peek());
        min.Push(val);
    }
    
    public void Pop() {
        st.Pop();
        min.Pop();
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        if (min.Count == 0) return 0;
        return min.Peek();
    }
}
