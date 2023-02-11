public class Solution {
    public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges) {

        var red = new List<int>[n];
        var blue = new List<int>[n];
        for (int i = 0 ; i < n ; i++)
        {
            red[i]=new List<int>();
            blue[i]=new List<int>();
        }
        foreach (var item in redEdges) red[item[0]].Add(item[1]);
        foreach (var item in blueEdges) blue[item[0]].Add(item[1]);
        var queue = new Queue<int>();
        queue.Enqueue(0);
        var r_ans = Enumerable.Repeat((int)1e9,n).ToList();
        var b_ans = Enumerable.Repeat((int)1e9,n).ToList();
        r_ans[0]=0;
        b_ans[0]=0;
        while (queue.Count>0)
        {
            int node=queue.Dequeue();
            if(r_ans[node] != (int)1e9)
            {
                foreach (var it in blue[node])
                {
                    if(b_ans[it] > r_ans[node]+1)
                    {
                        b_ans[it] = r_ans[node]+1;
                        queue.Enqueue(it);
                    }
                }
            }
            if(b_ans[node] != (int)1e9)
            {
                foreach (var it in red[node])
                {
                    if(r_ans[it] > b_ans[node]+1)
                    {
                        r_ans[it] = b_ans[node]+1;
                        queue.Enqueue(it);
                    }
                }
            }
        }
        int[] res=new int[n];
        for (int i = 0 ; i < n ; i++)
        {
            res[i]=Math.Min(r_ans[i],b_ans[i]);
            if (res[i] == (int)1e9) res[i]=-1;
        }
        return res;
    }
}
