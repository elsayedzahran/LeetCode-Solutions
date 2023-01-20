public class Solution {
public class ListEqCompare : IEqualityComparer<List<int>>
{
    public bool Equals(List<int> x, List<int> y)
    {
        if (x.Count != y.Count)
            return false;
        for (int i = 0; i < x.Count; i++)
        {
            if (x[i] != y[i])
                return false;
        }
        return true;
    }

    public int GetHashCode(List<int> obj)
    {
        int hash = 0;
        foreach (int num in obj)
            hash = hash ^ EqualityComparer<int>.Default.GetHashCode(num);

        return hash;
    }
}

    public IList<IList<int>> FindSubsequences(int[] nums) {
        var set=new  List<List<int>>();
        var list=new List<int>();   
        solve(0,set,list,nums);
        var newList = set.Distinct(new ListEqCompare());
        IList<IList<int>> res=new List<IList<int>>();
        foreach(var i in newList)
        {
            res.Add(i);
        }
        return res;
    }
    void solve(int idx,List<List<int>> set,List<int> list,int[] nums)
    {
        if (idx == nums.Length)
        {
            if (list.Count>1) 
            {
                set.Add(list.ToList());
            }
            return;
        }
        if (list.Count==0||list[list.Count-1]<=nums[idx])
        {
            list.Add(nums[idx]);
            solve(idx+1,set,list,nums);
            list.RemoveAt(list.Count-1);
        }
        solve(idx+1,set,list,nums);
    }

}
