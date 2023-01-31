class Solution {
public:
int dp[1005][1005];
    int bestTeamScore(vector<int>& scores, vector<int>& ages) {
        vector<pair<int,int>>v;
        int n=scores.size();
        memset(dp,-1,sizeof(dp));
        for(int i=0;i<n;i++)
        {
            v.push_back({scores[i],ages[i]});
        }
        sort(v.begin(),v.end());
        return solve(0 , 0 , n , v);
    }
    int solve(int idx, int prev,int n,vector<pair<int,int>>&v)
    {
        if (idx==n) return 0;
        if (dp[idx][prev]!=-1) return dp[idx][prev];
        int calc1 = solve(idx+1 , prev , n , v);
        int calc2=0;
        if (v[idx].second >= prev)
        {
            calc2=v[idx].first + solve(idx+1 , v[idx].second , n , v);
        }
        return dp[idx][prev] = max(calc1 , calc2);
    }
};
