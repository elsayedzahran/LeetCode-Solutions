public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int gs=0;
        int cst=0;
        foreach(var i in gas) gs+=i;
        foreach(var i in cost) cst+=i;
        if (cst>gs) return -1;
        int res=0,tank=0;
        for (int i=0;i<gas.Length;i++)
        {
            tank+=gas[i]-cost[i];
            if (tank<0)
            {
                tank=0;
                res=i+1;
            }
        }
        return res;
        
    }
}
