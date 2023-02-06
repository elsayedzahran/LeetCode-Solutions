public class Solution {
    public int LastStoneWeight(int[] stones) {
        var q = new PriorityQueue<int, int>(stones.Select(x => (x, -x)));
        while (q.Count > 1)
        {
            int a = q.Dequeue() - q.Dequeue();
            if (a != 0) q.Enqueue(a, -a);
        }
        return (q.Count == 0) ? 0 : q.Peek();        
    }
}
