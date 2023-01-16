public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var list=new List<List<int>>();
        foreach(var pp in intervals)
        {
            if(pp[1]<newInterval[0]) list.Add(new List<int>{pp[0], pp[1]});
            else if(newInterval[1]<pp[0]){
                list.Add(new List<int>{newInterval[0],newInterval[1]});
                newInterval=pp;
            }
            else{
                newInterval[0]=Math.Min(newInterval[0],pp[0]);
                newInterval[1]=Math.Max(newInterval[1],pp[1]);
            }   
        }
        list.Add(new List<int>{newInterval[0],newInterval[1]});
        int sz=list.Count;
        int[][] res=new int[sz][];
        int i=0;
        foreach(var item in list)
        {
            res[i++]=new int []{item[0],item[1]};
        }
        
        return res;
    }
}
