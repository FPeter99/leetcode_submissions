auto init = []()
{
    ios::sync_with_stdio(false);
    cin.tie(0);
    cout.tie(0);
    return 0;
}();

class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        std::unordered_set<int> mySet;
        for(int i : nums){
            if(!mySet.insert(i).second){
                return true;
            }
        }
    return false;
    }
};
