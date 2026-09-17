public class MinStack {

    public Stack<int> stack;
    public Stack<int> minstack;

    public MinStack() {
        stack = new Stack<int>();
        minstack = new Stack<int>();
    }
    
    public void Push(int val){

        stack.Push(val);
        
        if(minstack.Count > 0)
        {
            if(val < minstack.Peek())
            {
                minstack.Push(val);
            }
            else
            {
                minstack.Push(minstack.Peek());
            }
        }
        else // ha üres
        {
            minstack.Push(val);
        }
    }
    
    public void Pop() {
        stack.Pop();
        minstack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minstack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(value);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */