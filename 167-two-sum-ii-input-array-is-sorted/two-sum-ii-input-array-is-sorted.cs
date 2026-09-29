public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int bal = 0;
        int jobb = numbers.Count() - 1;
        int sum = numbers[bal] + numbers[jobb];
        while(sum != target)
        {
            if(sum > target)
            {
                jobb--;
            }
            else
            { 
                bal++;
            }
            sum = numbers[bal] + numbers[jobb];
        }
        bal++;
        jobb++;
        return new int[] { bal, jobb };
    }
}
