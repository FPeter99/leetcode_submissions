public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> volt = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(volt.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                volt.Add(nums[i]);
            }
        }
        return false;
    }
}