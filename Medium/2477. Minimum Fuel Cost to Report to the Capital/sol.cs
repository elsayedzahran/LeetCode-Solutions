public class Solution {
    long res=0;
    public long MinimumFuelCost(int[][] roads, int seats) {
        var adj = new List<List<int>>(roads.Length+1);
        for (int i = 0 ; i < roads.Length+1 ; i++) adj.Add(new List<int>());
        foreach (var road in roads)
        {
            adj[road[0]].Add(road[1]);
            adj[road[1]].Add(road[0]);
        }
        DFS(0, 0, adj, seats);
        return res;
    }
    int DFS(int idx, int par, List<List<int>> adj, int seats){
        int cur = 1;
        foreach (var item in adj[idx])
        {
            if (item != par) cur += DFS(item, idx, adj, seats);
        }
        if (idx != 0) res += (cur + seats - 1) / seats;
        return cur;
    }
}
