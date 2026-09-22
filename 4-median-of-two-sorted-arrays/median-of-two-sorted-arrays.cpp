class Solution {
public:
    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2) {
        vector<int> both = nums1;
        for(int i = 0; i < nums2.size(); i++){
            both.push_back(nums2.at(i));
        }
        std::sort(both.begin(), both.end());
        /*
        for(int i = 0; i < both.size(); i++){
            std::cout << both[i];
        }
        std::cout << '\n';
            std::cout << both.size();
        */

        if(both.size() % 2 == 0){
            //páros;
            return(double(both[(both.size() - 1) / 2]) + both[both.size() / 2]) / 2;
        }else{
            return both[both.size() / 2];
        }
    }
};
