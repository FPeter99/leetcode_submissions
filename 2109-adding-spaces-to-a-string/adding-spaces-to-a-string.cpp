class Solution {
public:
    string addSpaces(string s, vector<int>& spaces) {

        std::string to_return;

        //convert to index
        for(int i = 0; i < spaces.size(); i++){
            spaces[i] += i;
        }

        int poz_spaces = 0;
        int poz_string = 0;
        for(int index = 0; index < s.size() + spaces.size(); index++){
            if(poz_spaces < spaces.size() && index == spaces[poz_spaces]){
                to_return +=" ";
                poz_spaces++;
            }else{
                to_return += s[poz_string];
                poz_string++;
            }
            
        }
        return to_return;
    }
};
