public class Solution {
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if ("([{".Contains(s[i]))
            {
                stack.Push(s[i]);
            }
            else if (stack.Count == 0)
            {
                // random záró zárójel => nem jó, false
                return false;
            }
            else if (s[i] == returnPair(stack.Peek()))
            {
                stack.Pop();
            }
            else 
            {
                // ha nem nyitó és nem zárunk be egyet akkor hiba: [(])
                return false;
            }
        }

        if (stack.Count() == 0) 
        {
            return true;
        }
        return false;
    }

    char returnPair(char p)
    {
        switch (p)
        {
            case '(': return ')';
            case '{': return '}';
            case '[': return ']';
            default: return ' ';
        }
    }
}