public class Solution {
    public int MaxProfit(int[] prices) {
        int res=0,cur=prices[0];
        foreach(var item in prices)
        {
            res=Math.Max(res,item-cur);
            cur=Math.Min(cur,item);
        }
        return res;
    }
}
