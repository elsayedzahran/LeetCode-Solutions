public class Solution {
    int res=0;
    public int LongestPath(int[] parent, string s) {
        var adj=new List<List<int>>();
        for(int i=0; i<parent.Length ; i++)
        {
           adj.Add(new List<int>());
        }
        for(int i=0; i<parent.Length ; i++)
        {
            if (parent[i]==-1) continue;
            adj[parent[i]].Add(i);
        }
        traverse(0,adj,s);
        return res+1;
    }
    int traverse(int node,List<List<int>> adj,string s)
    {
        int max=0;
        int sec_max=0;
        foreach(var child in adj[node])
        {
           
            int childPath = traverse(child,adj,s);
             if (s[node] == s[child]) continue;
            if (childPath > max) {sec_max=max;max=childPath;}
            else if (childPath > sec_max) sec_max=childPath;
        }
        if (max+sec_max>res) res=max+sec_max;
        return max+1;
    }
}
