public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum=0,res=nums[0];
        for (int i=0; i<nums.Length;i++)
        {
            sum += nums[i];
            sum=Math.Max(nums[i],sum);
		    res=Math.Max(res,sum);
        }
        return res;
    }
}
