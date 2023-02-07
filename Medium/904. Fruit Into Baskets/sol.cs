public class Solution {
    public int TotalFruit(int[] fruits) {
        int l = 0, r = 0, n = fruits.Length;
        var map = new Dictionary<int,int>();
        while(l < n){
            int l_fruits = fruits[l];
            if (!map.ContainsKey(l_fruits)) map.Add(l_fruits,0);
            map[l_fruits]++;
            if (map.Count > 2){
                int r_fruits = fruits[r];
                map[r_fruits]--;
                if (map[r_fruits] == 0) map.Remove(r_fruits);
                r++;
            }
            l++;
        }
        return l-r;
    }
}
