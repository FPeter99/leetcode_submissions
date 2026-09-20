class Solution {
public:
    int reverse(int x) {

        long to_return = 0;

        while(x != 0){
            to_return =(to_return * 10) + (x % 10);
            x /= 10;
        }

        if(to_return > INT_MAX || to_return < INT_MIN){
            return 0;
        }

        return to_return; 
    }
};
