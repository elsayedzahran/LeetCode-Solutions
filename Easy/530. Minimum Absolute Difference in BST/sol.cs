/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int GetMinimumDifference(TreeNode root) {
        var tree = new List<int>();
        Traverse(root, tree);

        int res = int.MaxValue;

        for(int i=1; i<tree.Count; i++){
            res = Math.Min(res, tree[i]-tree[i-1]);
        }

        return res;
    }
    void Traverse(TreeNode root, List<int> tree){
        if(root == null) return;
        
        Traverse(root.left, tree);
        tree.Add(root.val);
        Traverse(root.right, tree);
    }
}
