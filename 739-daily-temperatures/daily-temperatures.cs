public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] m = new int[temperatures.Count()];

        Stack<int> stack = new Stack<int>();


        for(int i = 0; i<temperatures.Length; i++) 
        {
            m[i] = 0;
            while (stack.Count>0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int index = stack.Pop();
                m[index] = i - index;
            }
            stack.Push(i);

        }

        return m;
    }
}