public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image[sr][sc] != color) dfs(sr, sc, image[sr][sc], color , image);
        return image;
    }
    void dfs(int sr,int sc,int replacingColor, int newColor , int[][] image)
    {
        image[sr][sc] = newColor;
        if (sr > 0 && image[sr - 1][sc] == replacingColor)
        {
            dfs( sr - 1, sc, replacingColor, newColor,image);
        }
        if (sr < image.Length - 1 && image[sr + 1][sc] == replacingColor)
        {
            dfs(sr + 1, sc, replacingColor, newColor,image);
        }
        if (sc > 0 && image[sr][sc - 1] == replacingColor)
        {
            dfs( sr, sc - 1, replacingColor, newColor,image);
        }
        if (sc < image[sr].Length - 1 && image[sr][sc + 1] == replacingColor)
        {
            dfs(sr, sc + 1, replacingColor, newColor,image);
        }
    }

}
