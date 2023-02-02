public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int first = 0;
        int second = 0;
        int res = 0;
        for(int i = 2; i <= cost.Length ; i++) 
        {
            res = Math.Min(first + cost[i - 2] , second + cost[i - 1]);
            first = second;
            second = res;
        }
        return res;
    }
}
