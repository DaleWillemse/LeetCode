public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1;
        foreach (int number in nums)
        {
            if (nums[k - 1] != number)
            {

                nums[k++] = number;

            }
        }
        return k;
    }
}