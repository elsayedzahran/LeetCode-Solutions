public class Solution {
    int[] x={0,0,1,-1};
    int[] y={1,-1,0,0};
    int n,m;
    public int NumIslands(char[][] grid) {
        n=grid.Length;
        m=grid[0].Length;
        int res=0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if (grid[i][j]=='1')
                {
                    res++;
                    dfs(i,j,grid);
                }
            }
        }
        return res;
    }
    void dfs(int i,int j,char[][] grid)
    {
        try{if (i>=n||j>=m) return;
        if (grid[i][j]=='0') return;
        grid[i][j]='0';
        for(int k=0;k<4;k++)
        {
            int ni = i + x[k];
            int nj = j + y[k];
            dfs(ni,nj,grid);
        }}catch{}
    }
}
