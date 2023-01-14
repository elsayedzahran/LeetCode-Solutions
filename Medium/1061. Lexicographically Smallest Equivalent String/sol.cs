public class Solution {
    public string SmallestEquivalentString(string s1, string s2, string baseStr) {
        var DSU=new UnionFindSet(26);
        for(int i=0;i<s1.Length;i++)
        {
            DSU.Union(s1[i] - 'a', s2[i] - 'a');
        }
        var res="";
        foreach (var it in baseStr)
        {
            res+=((char)(DSU.Find(it-'a')+'a'));
        }
        return res;
    }
  public class UnionFindSet
{
        private int[] parent;

        public UnionFindSet(int size)
        {
            parent = new int[size];
            for (int i = 0; i < parent.Length; ++i)
            {
                parent[i] = i;
            }
        }
        public void Union(int x, int y) 
        {
            var parentX = Find(x);
            var parentY = Find(y);
            if (parentX == parentY) return;
            if (parentX < parentY) parent[parentY] = parentX;
            else parent[parentX] = parentY;
        }
        public int Find(int x)
        {
            if (parent[x] != x) parent[x] = Find(parent[x]);
            return parent[x];
        }  
}
}    


