public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] toReturn = new int[nums.Length];

        // először hozzáadjuk a megelőző elemek szorzatát az array-hoz, majd utána az azt követő elemek szorzatával szorozzuk fel
        int temp = 1;
        for (int i = 0; i < nums.Count(); i++)
        {
            // először hozzáadjuk majd utána szorozzuk hogy a következő pl 2. indexű megkapja az előtte lévő tagok szorzatát
            toReturn[i] = temp;
            temp = temp * nums[i];
        }

        temp = 1;
        for (int i = nums.Count(); i > 0; i--)
        {
            toReturn[i-1] = toReturn[i-1] * temp;
            temp = temp * nums[i-1];
        }

        return toReturn;
    }
}
