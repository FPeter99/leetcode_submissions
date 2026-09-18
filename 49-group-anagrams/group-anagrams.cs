public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

        for(int i = 0; i<strs.Count(); i++)
        {
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            if(dict.ContainsKey(sorted))
            {
                dict[sorted].Add(strs[i]);
            }
            else
            {
                dict.Add(sorted, new List<string> {strs[i]});
            }
        }
        return dict.Values.ToList();
    }
}
