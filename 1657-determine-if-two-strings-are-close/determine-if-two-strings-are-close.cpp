class Solution {
public:
    bool closeStrings(string word1, string word2) {

        // Ha a két szó hossza nem egyezik, nem lehet close
        if (word1.length() != word2.length()) {
            return false;
        }

        // Hash map a karakterek előfordulásának számolásához
        std::unordered_map<char, int> umm1;
        std::unordered_map<char, int> umm2;

        for (char ch : word1) {
            umm1[ch]++;
        }
        for (char ch : word2) {
            umm2[ch]++;
        }

        // Ellenőrizze, hogy mindkét szó tartalmazza ugyanazokat a karaktereket
        for (const auto& pair : umm1) {
            if (umm2.find(pair.first) == umm2.end()) {
                return false;  // Ha az egyikben van, a másikban nincs a karakter
            }
        }

        // Ellenőrizze, hogy a karakterek előfordulása hasonló legyen
        vector<int> freq1, freq2;
        for (const auto& pair : umm1) {
            freq1.push_back(pair.second);
        }
        for (const auto& pair : umm2) {
            freq2.push_back(pair.second);
        }

        // Ha a karakterek előfordulásainak száma nem egyezik, nem close
        sort(freq1.begin(), freq1.end());
        sort(freq2.begin(), freq2.end());

        return freq1 == freq2;
    }
};
