class Solution {
public:
    vector<string> fizzBuzz(int n) {
        vector<string> list;
        for(int i = 1; i <= n; i++){
            if(i % 3 == 0 && i % 5 == 0){
                list.push_back("FizzBuzz");
            }else if(i % 5 ==0){
                list.push_back("Buzz");
            }else if(i % 3 == 0){
                list.push_back("Fizz");
            }else{
                
                list.push_back(std::to_string(i));
            }
        }
        return list;
    }
};
