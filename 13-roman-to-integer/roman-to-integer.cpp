#include <string>
using namespace std;

class Solution {
public:
    int returnValue(char c) {
        switch(c) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }


    int romanToInt(string s) {

        int sum = 0;

        for(int i = 0; i < s.size() - 1; i++) {

            if(returnValue(s[i]) < returnValue(s[i + 1])) {
                sum -= returnValue(s[i]);

            } else {
                sum += returnValue(s[i]);
            }
        }

        sum += returnValue(s[s.size() - 1]);

        return sum;
        
    }
};
