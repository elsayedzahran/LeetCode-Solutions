public class Solution {
    public int ClosestMeetingNode(int[] edges, int node1, int node2) {
        int[] dest1=new int[edges.Length];
        int[] dest2=new int[edges.Length];
        Array.Fill(dest2, int.MaxValue);
        Array.Fill(dest1, int.MaxValue);
        dfs(edges,node1,dest1);
        dfs(edges,node2,dest2);
        int val=10000000,res=-1;
        for (int i=0;i<edges.Length;i++)
        {
            if (Math.Max(dest1[i],dest2[i])<val)
            {
                res=i;
                val = Math.Max(dest1[i],dest2[i]);
            }
        }
        return res;
    }
    void dfs(int[] edges,int node,int[] dest)
    {
        var sum=0;
        while(node!=-1&&dest[node]==int.MaxValue)
        {
            dest[node]=sum++;
            node=edges[node];
        }
        
    }
}
