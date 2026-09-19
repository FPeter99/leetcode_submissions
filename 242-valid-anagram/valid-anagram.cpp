class Solution {
public:
    bool isAnagram(string s, string t) {

        if (s.size() != t.size()) {
            return false;
        }
        
        std::unordered_map<char, int> count;
        

        for (char c : s) {
            count[c]++;
        }
        

        for (char c : t) {
            if (count.find(c) == count.end() || count[c]-- <= 0) {
                return false;
            }
        }
        
        return true;
    }
};
