public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> Num_Count = new Dictionary<int, int>();

        for (int i = 0; i < nums.Count(); i++) 
        {
            if (Num_Count.ContainsKey(nums[i]))
            {
                Num_Count[nums[i]]++;
            }
            else 
            {
                Num_Count[nums[i]] = 1;
            }
        }

        return Num_Count.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();
    }
}
