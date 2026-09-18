class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        if(nums.size() > 1){
            for(int i = 0; i < nums.size() - 1; i++){
                if(nums.at(i) == nums.at(i + 1)){
                    nums.erase(nums.begin() + i);
                    i--;
                }
            }
        }
        return nums.size();
    }
};
