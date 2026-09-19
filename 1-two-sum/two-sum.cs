public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> ValueIndex = new Dictionary<int, int>();

        for(int i = 0; i < nums.Count(); i++)
        {
            int toFind = target-nums[i];
            if(ValueIndex.ContainsKey(toFind))
            {
                return new int[] { i, ValueIndex[toFind] };
            }
            ValueIndex[nums[i]] = i;
        }
        return new int[0];
    }
}
