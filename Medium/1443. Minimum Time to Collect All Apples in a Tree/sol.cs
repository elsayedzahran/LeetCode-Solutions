public class Solution {
    public int MinTime(int n, int[][] edges, IList<bool> hasApple) {
        var adj=new Dictionary<int,List<int>>();
        foreach(var edge in edges)
        {
            if (!adj.ContainsKey(edge[0])) adj.Add(edge[0],new List<int>());
            if (!adj.ContainsKey(edge[1])) adj.Add(edge[1],new List<int>());
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }
        var vis = Enumerable.Repeat(false, n).ToList();
        var res=dfs(0,vis,adj,hasApple);
        if (res<0) res=0;
        return res;
    }
    public static int dfs(int idx,IList<bool> vis,Dictionary<int,List<int>> adj,IList<bool> hasApple){
        int res=0;
        vis[idx]=true;
        foreach(var item in adj[idx])
        {
            if (!vis[item])
            {
                var time=dfs(item,vis,adj,hasApple);
                if(time>=0) res+=(time+2);
            }
        }
        if(hasApple[idx] || res>0) return res;
        return -1;
    }
}
