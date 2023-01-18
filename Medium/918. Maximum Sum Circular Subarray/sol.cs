public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int sum=0,res=nums[0];
        foreach (var i in nums)
        {
            sum += i;
            sum=Math.Max(i,sum);
		    res=Math.Max(res,sum);
        }
        int min=100000,minsum=0;
        foreach (var i in nums)
        {
            minsum += i;
            minsum=Math.Min(i,minsum);
		    min=Math.Min(min,minsum);
        }
        int total=0;
        foreach (var i in nums) total+=i;
        total-=min;
        return Math.Max(res,total!=0?total:-100000);
    }
}
