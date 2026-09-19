public class Solution {
    public bool IsAnagram(string s, string t) {

        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();

        for(int i = 0; i<s.Length; i++){
            if(sDict.ContainsKey(s[i]))
            {
                sDict[s[i]]++;
            }else
            {
                sDict.Add(s[i], 1);
            }
        }

        for(int i = 0; i<t.Length; i++){
            if(tDict.ContainsKey(t[i]))
            {
                tDict[t[i]]++;
            }else
            {
                tDict.Add(t[i], 1);
            }
        }

        foreach(var i in sDict)
        {
            if(!tDict.ContainsKey(i.Key) || i.Value != tDict[i.Key]){return false;}
        }
        if (s.Length != t.Length){return false;} 
        return true;
    }
}
