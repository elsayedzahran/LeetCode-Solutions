public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        int pre=0,res=0;
        Dictionary<int,int> freq=new Dictionary<int,int>();
        freq[0]=1;
        foreach (var num in nums)
        {
            pre=(pre + num%k + k)%k;
            if (!freq.ContainsKey(pre)) freq.Add(pre,0);
            res+=freq[pre];
            freq[pre]++;
        }
        return res;
    }
}
