class Solution {
public:
    int maxArea(vector<int>& height) {
        int bal = 0;
        int jobb = height.size()-1;
        if(jobb == 1){
            return min(height[0], height[1]);
        }
        int max = 0;
        while(bal < jobb){

            int max_seged = min(height[bal], height[jobb]) * (jobb - bal);

            if(max_seged > max){
                max = max_seged;
            }

            if(height[bal] < height[jobb]){
                bal++;
            }else{
                jobb--;
            }
            
        }
        return max;
    }
};
