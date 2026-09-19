public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int maxLength = 0;
        if(set.Count() > 0)
        {
            maxLength = 1;
        }
        else{return 0;}
        foreach(int num in set)
        {
            if(!set.Contains(num-1)) // sorozat kezdete
            {
                int temp = num;
                int length = 1;

                while(true)
                {
                    if(set.Contains(temp+1))
                    {
                        length++;
                        temp++;
                        if(length > maxLength)
                        {
                            maxLength = length;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        return maxLength;
    }
}
