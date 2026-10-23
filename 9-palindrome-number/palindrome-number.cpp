class Solution {
public:
    bool isPalindrome(int x) {
        if(x<0){return false; }
        int eredeti = x;
        // bruh
        long long forditott = 0;
        while(x>0)
        {
            forditott = (forditott * 10) + (x % 10);
            x /= 10;
        }
        return eredeti == forditott;
    }
};