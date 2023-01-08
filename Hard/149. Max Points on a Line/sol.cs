public class Solution {
    public int MaxPoints(int[][] points) {
        if (points.Length==1) return 1;
        int result=2;
        foreach (var sub in points)
        {
            Dictionary<double,int> dict=new Dictionary<double,int>();
            for (int i=0;i<points.Length ; i++)
            {
                if (points[i][0]==sub[0]&&points[i][1]==sub[1]) continue;
                double slope=0;
                slope= Math.Atan2(points[i][1]-sub[1],points[i][0]-sub[0]);
                if (dict.ContainsKey(slope))
                {
                    dict[slope]++;
                    if (dict[slope]>result) result=dict[slope];
                }
                else dict.Add(slope,2);

            }
        }
        return result;
    }
}
