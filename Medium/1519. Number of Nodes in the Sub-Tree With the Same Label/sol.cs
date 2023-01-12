public class Solution {
    public int[] CountSubTrees(int n, int[][] edges, string labels) {
        var adj=new Dictionary<int,List<int>>();
        foreach(var edge in edges)
        {
            if (!adj.ContainsKey(edge[0])) adj.Add(edge[0],new List<int>());
            if (!adj.ContainsKey(edge[1])) adj.Add(edge[1],new List<int>());
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }
        var vis = Enumerable.Repeat(false, n).ToList();
        var ans = Enumerable.Repeat(0, n).ToArray();
        dfs(0,vis,adj,ans,labels);
        return ans;
    }
    public static IList<int> dfs(int idx,IList<bool> vis,Dictionary<int,List<int>> adj,int[] ans,string label){
        vis[idx]=true;
        var ret = Enumerable.Repeat(0, 26).ToList();
        ret[label[idx]-'a']++;
        foreach(var item in adj[idx])
        {
            if (!vis[item])
            {
               var sub=dfs(item,vis,adj,ans,label);
               for(int i=0;i<26;i++)
               {
                   ret[i]+=sub[i];
               }
            }
        }
        ans[idx]=ret[label[idx]-'a'];
        return ret;
    }
}
