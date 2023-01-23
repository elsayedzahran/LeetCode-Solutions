public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] pre=new int[nums.Length];
        pre[0]=nums[0];
        for (int i=1;i<nums.Length;i++)
        {
            pre[i]=nums[i]+pre[i-1];
        }
        return pre;
    }
}
