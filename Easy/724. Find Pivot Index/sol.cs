public class Solution {
    public int PivotIndex(int[] nums) {
        int n=nums.Length;
        int[] pre=new int[n];
        int[] suf=new int[n];
        pre[0]=nums[0];
        suf[n-1]=nums[n-1];
        if (n==1) return 0;
        for(int i=1;i<n;i++) pre[i]=pre[i-1]+nums[i];
        for(int i=n-2;i>=0;i--) suf[i]=suf[i+1]+nums[i];
        if (suf[1]==0) return 0;
        for(int i=1;i<n-1;i++)
        {
            if (pre[i-1]==suf[i+1]) return i;
        }
        if (pre[n-2]==0) return n-1;
        return -1;
    }
}
