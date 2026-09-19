class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        std::unordered_map<int, int> num_index; // érték : index
        for(int i = 0; i < nums.size(); i++){
            int to_find = target - nums[i];
            if(num_index.count(to_find)){
                return {num_index[to_find], i};
            }
            num_index[nums[i]] = i;
        }
        return {};
    }
};
