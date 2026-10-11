public class Solution {
    public int SumOfSquares(int[] nums) {
        int sum = 0;
        int l = nums.Length;
        for(int i = 0; i<l; i++)
        {
            if(l % (i+1) == 0)
            {
                sum += nums[i] * nums[i];
            }
        }
        return sum;
    }
}