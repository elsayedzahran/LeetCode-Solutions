public class Solution {
    public int Jump(int[] nums) {
        var dic = new Dictionary<int, int>();
        var res = Jump(0, dic, nums);
        return res;
    }
    int Jump(int index, Dictionary<int, int> dic, int[] nums)
    {
        if (dic.ContainsKey(index)) return dic[index];
        if (index == nums.Length - 1) return 0;
        if (nums[index] == 0) return -1;
        if (index + nums[index] >= nums.Length - 1) return 1;
        var res = nums.Length;
        for (int i = Math.Min(nums[index], nums.Length - index - 1) - 1; i >= 0 ; i--)
        {
            var cur = Jump(index + 1 + i, dic, nums);
            if (cur != -1 && res > cur) res = cur;
        }
        res++;
        if (!dic.ContainsKey(index)) dic.Add(index, res);
        return res;
    }
}
