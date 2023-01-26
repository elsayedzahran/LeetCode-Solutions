public class Solution {
    public class Pair<T, U> {
    public Pair() {
    }

    public Pair(T first, U second) {
        this.First = first;
        this.Second = second;
    }

    public T First { get; set; }
    public U Second { get; set; }
    
    };
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        var adj=new List<List<Pair<int,int>>>();
        for(int i=0;i<n;i++) adj.Add(new List<Pair<int,int>>());
        foreach(var flight in flights)
        {
            adj[flight[0]].Add(new Pair<int,int>(flight[1],flight[2]));
        }
        int[] res=Enumerable.Repeat(int.MaxValue,n).ToArray();
        Queue<List<int>> q=new Queue<List<int>>();
        q.Enqueue(new List<int>(){src,0,0});
     
        while(q.Count>0)
        {
            var flight = q.Peek();
            q.Dequeue();
            int node = flight[0];
            int nodeCost = flight[1];
            int kk = flight[2];
            if (kk > k) continue;
            foreach (var  ch in adj[node]) {
                int childCost=ch.Second;
                int child=ch.First;
                if (child>=0&&child<n&&childCost + nodeCost < res[child])
                {
                    res[child] = childCost + nodeCost;
                    q.Enqueue(new List<int>(){child, res[child], kk + 1});
                }
            }
        }
      return res[dst] == int.MaxValue? -1 : res[dst];
    }
}
