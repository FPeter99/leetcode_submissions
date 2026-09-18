public class Solution {
    public int EvalRPN(string[] tokens) {

        Stack<int> stack = new Stack<int>();

        int felso;
        int also;
        foreach(string elem in tokens)
        {
            switch (elem)
            {
                case "+": 
                    felso = stack.Pop();
                    also = stack.Pop();
                    stack.Push(also + felso);
                    break;
                case "-":
                    felso = stack.Pop();
                    also = stack.Pop();
                    stack.Push(also - felso);
                    break;
                case "*":
                    felso = stack.Pop();
                    also = stack.Pop();
                    stack.Push(also * felso);
                    break;
                case "/":
                    felso = stack.Pop();
                    also = stack.Pop();
                    stack.Push((also / felso));
                    break;
                default: 
                    stack.Push(Convert.ToInt32(elem));
                    break;
            }
        }
        return stack.Peek();
    }
}