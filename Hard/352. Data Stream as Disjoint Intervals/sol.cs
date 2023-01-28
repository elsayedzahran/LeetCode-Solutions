public class SummaryRanges {
    SortedSet<int> values;
    public SummaryRanges() {
        values = new SortedSet<int>();
    }
    
    public void AddNum(int value) {
        values.Add(value);
    }
    
    public int[][] GetIntervals() {
        if (values.Count()==0) return new int[0][];
        List<int[]> intervals = new List<int[]>();
        int left = -1, right = -1;
        foreach (var value in values) 
        {
            if (left < 0) left = right = value;
            else if (value == right + 1) right = value;
            else
            {
                intervals.Add(new int[] {left, right});
                left = right = value;
            } 
        }
        intervals.Add(new int[] {left, right});
        return intervals.ToArray();
    }
}

/**
 * Your SummaryRanges object will be instantiated and called as such:
 * SummaryRanges obj = new SummaryRanges();
 * obj.AddNum(value);
 * int[][] param_2 = obj.GetIntervals();
 */
