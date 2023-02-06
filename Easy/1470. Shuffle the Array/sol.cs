public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var res=new int[n*2];
        int idx = 0;
        for (int i = 0 ; i+n < 2*n ; i++)
        {
            res[idx++] = nums[i];
            res[idx++] = nums[i+n]; 
        }
        return res;
    }
}
