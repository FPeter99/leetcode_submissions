class Solution {
public:
    int maxProfit(vector<int>& prices) {
        //prices = 2, 4, 6, 2, 5, 6, 5, 3;
        int profit = 0;
        int buy_price;
        int sell_price;
        for(int day = 0; day < prices.size() -1; day++){
            if(prices.at(day) < prices.at(day + 1)){
                //buy
                profit += prices.at(day + 1) - prices.at(day);
            }else if(prices.at(day) > prices.at(day + 1)){
                //sell
            }
        }
    return profit;
    }
};
