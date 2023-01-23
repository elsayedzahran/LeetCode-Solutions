public class Solution {
    public int FindJudge(int n, int[][] trust) {
        int res=-1;
        int[] count = new int[n+1];
        var ans=new List<List<int>>();
        foreach(var i in trust)
        {
            count[i[1]]++;
            count[i[0]]--;
        }
        for(int i=0;i<count.Length;i++) if(count[i]>=n-1) res=i;
        return res;
    }
}
