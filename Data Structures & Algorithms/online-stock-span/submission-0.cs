public class StockSpanner {
    Stack<int[]> st = [];
    public StockSpanner() {
        
    }
    
    public int Next(int price) {
        int res = 1;
        while (st.Count > 0 && st.Peek()[0] <= price) {
            res += st.Pop()[1];
        }
        st.Push(new int[] {price, res});
        return res;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */