public class Solution {
    public bool hasDuplicate(int[] nums) {
        int i, j;
        for(i = 0; i < nums.Length; i++)
        {
            for(j = 1 + i; j < nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}